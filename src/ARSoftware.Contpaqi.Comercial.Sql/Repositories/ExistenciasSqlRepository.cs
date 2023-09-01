using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Almacenes;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.CapasProducto;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.ProductosDetalles;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresCaracteristicas;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar existencias de productos.
/// </summary>
public sealed class ExistenciasSqlRepository : IExistenciasSqlRepository
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ExistenciasSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public double BuscaExistencias(string codigoProducto, string codigoAlmacen, DateOnly fecha)
    {
        var fechaCorte = fecha.ToDateTime(TimeOnly.MinValue);

        var producto = _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO })
            .Single();

        var almacen = _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .Single();

        var movimientos = _context.admMovimientos
            .WithSpecification(new MovimientosParaCalculoExistenciasSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, fechaCorte))
            .Select(m => new { m.CAFECTAEXISTENCIA, m.CUNIDADES })
            .ToList();

        double entradas = movimientos.Where(m => m.CAFECTAEXISTENCIA == 1).Sum(m => m.CUNIDADES);
        double salidas = movimientos.Where(m => m.CAFECTAEXISTENCIA == 2).Sum(m => m.CUNIDADES);

        return entradas - salidas;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCapas(string codigoProducto, string codigoAlmacen, string pedimento, string lote)
    {
        var producto = _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO })
            .Single();

        var almacen = _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .Single();

        var capas = _context.admCapasProducto
            .WithSpecification(
                new CapaPorProductoAlmacenPedimentoLoteSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, pedimento, lote))
            .Select(c => new { c.CEXISTENCIA })
            .FirstOrDefault();

        return capas?.CEXISTENCIA ?? 0;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCaracteristicas(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string abreviaturaValorCaracteristica1, string abreviaturaValorCaracteristica2, string abreviaturaValorCaracteristica3)
    {
        var fechaCorte = fecha.ToDateTime(TimeOnly.MinValue);

        var producto = _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO, p.CIDPADRECARACTERISTICA1, p.CIDPADRECARACTERISTICA2, p.CIDPADRECARACTERISTICA3 })
            .Single();

        var almacen = _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .Single();

        admCaracteristicasValores? valor1 = _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA1,
                abreviaturaValorCaracteristica1))
            .FirstOrDefault();
        admCaracteristicasValores? valor2 = _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA2,
                abreviaturaValorCaracteristica2))
            .FirstOrDefault();
        admCaracteristicasValores? valor3 = _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA3,
                abreviaturaValorCaracteristica3))
            .FirstOrDefault();

        var movimientos = _context.admMovimientos
            .WithSpecification(new MovimientosParaCalculoExistenciasSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, fechaCorte))
            .Select(m => new { m.CIDMOVIMIENTO, m.CAFECTAEXISTENCIA, m.CUNIDADES })
            .ToList();

        var entradas = 0.0;
        var salidas = 0.0;

        foreach (var movimiento in movimientos)
        {
            var movimientoOculto = _context.admMovimientos
                .WithSpecification(new MovimientoOcultoPorOwnerIdSpecification(movimiento.CIDMOVIMIENTO))
                .Select(m => new { m.CIDPRODUCTO })
                .First();

            var productoDetalle = _context.admProductosDetalles.WithSpecification(new ProductoDetallePorId(movimientoOculto.CIDPRODUCTO))
                .Select(p => new { p.CIDVALORCARACTERISTICA1, p.CIDVALORCARACTERISTICA2, p.CIDVALORCARACTERISTICA3 })
                .First();

            if (productoDetalle.CIDVALORCARACTERISTICA1 == (valor1?.CIDVALORCARACTERISTICA ?? 0) &&
                productoDetalle.CIDVALORCARACTERISTICA2 == (valor2?.CIDVALORCARACTERISTICA ?? 0) &&
                productoDetalle.CIDVALORCARACTERISTICA3 == (valor3?.CIDVALORCARACTERISTICA ?? 0))
                switch (movimiento.CAFECTAEXISTENCIA)
                {
                    case 1:
                        entradas += movimiento.CUNIDADES;
                        break;
                    case 2:
                        salidas += movimiento.CUNIDADES;
                        break;
                }
        }

        return entradas - salidas;
    }

    /// <inheritdoc />
    public async Task<double> BuscaExistenciasAsync(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        CancellationToken cancellationToken)
    {
        var fechaCorte = fecha.ToDateTime(TimeOnly.MinValue);

        var producto = await _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO })
            .SingleAsync(cancellationToken);

        var almacen = await _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .SingleAsync(cancellationToken);

        var movimientos = await _context.admMovimientos
            .WithSpecification(new MovimientosParaCalculoExistenciasSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, fechaCorte))
            .Select(m => new { m.CAFECTAEXISTENCIA, m.CUNIDADES })
            .ToListAsync(cancellationToken);

        double entradas = movimientos.Where(m => m.CAFECTAEXISTENCIA == 1).Sum(m => m.CUNIDADES);
        double salidas = movimientos.Where(m => m.CAFECTAEXISTENCIA == 2).Sum(m => m.CUNIDADES);

        return entradas - salidas;
    }

    /// <inheritdoc />
    public async Task<double> BuscaExistenciasConCapasAsync(string codigoProducto, string codigoAlmacen, string pedimento, string lote,
        CancellationToken cancellationToken)
    {
        var producto = await _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO })
            .SingleAsync(cancellationToken);

        var almacen = await _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .SingleAsync(cancellationToken);

        var capas = await _context.admCapasProducto
            .WithSpecification(
                new CapaPorProductoAlmacenPedimentoLoteSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, pedimento, lote))
            .Select(c => new { c.CEXISTENCIA })
            .FirstOrDefaultAsync(cancellationToken);

        return capas?.CEXISTENCIA ?? 0;
    }

    /// <inheritdoc />
    public async Task<double> BuscaExistenciasConCaracteristicasAsync(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string abreviaturaValorCaracteristica1, string abreviaturaValorCaracteristica2, string abreviaturaValorCaracteristica3,
        CancellationToken cancellationToken)
    {
        var fechaCorte = fecha.ToDateTime(TimeOnly.MinValue);

        var producto = await _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .Select(p => new { p.CIDPRODUCTO, p.CIDPADRECARACTERISTICA1, p.CIDPADRECARACTERISTICA2, p.CIDPADRECARACTERISTICA3 })
            .SingleAsync(cancellationToken);

        var almacen = await _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .Select(a => new { a.CIDALMACEN })
            .SingleAsync(cancellationToken);

        admCaracteristicasValores? valor1 = await _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA1,
                abreviaturaValorCaracteristica1))
            .FirstOrDefaultAsync(cancellationToken);
        admCaracteristicasValores? valor2 = await _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA2,
                abreviaturaValorCaracteristica2))
            .FirstOrDefaultAsync(cancellationToken);
        admCaracteristicasValores? valor3 = await _context.admCaracteristicasValores
            .WithSpecification(new ValorCaracteristicaPorCaracteristicaIdYAbreviatura(producto.CIDPADRECARACTERISTICA3,
                abreviaturaValorCaracteristica3))
            .FirstOrDefaultAsync(cancellationToken);

        var movimientos = await _context.admMovimientos
            .WithSpecification(new MovimientosParaCalculoExistenciasSpecification(producto.CIDPRODUCTO, almacen.CIDALMACEN, fechaCorte))
            .Select(m => new { m.CIDMOVIMIENTO, m.CAFECTAEXISTENCIA, m.CUNIDADES })
            .ToListAsync(cancellationToken);

        var entradas = 0.0;
        var salidas = 0.0;

        foreach (var movimiento in movimientos)
        {
            var movimientoOculto = await _context.admMovimientos
                .WithSpecification(new MovimientoOcultoPorOwnerIdSpecification(movimiento.CIDMOVIMIENTO))
                .Select(m => new { m.CIDPRODUCTO })
                .FirstAsync(cancellationToken);

            var productoDetalle = await _context.admProductosDetalles
                .WithSpecification(new ProductoDetallePorId(movimientoOculto.CIDPRODUCTO))
                .Select(p => new { p.CIDVALORCARACTERISTICA1, p.CIDVALORCARACTERISTICA2, p.CIDVALORCARACTERISTICA3 })
                .FirstAsync(cancellationToken);

            if (productoDetalle.CIDVALORCARACTERISTICA1 == (valor1?.CIDVALORCARACTERISTICA ?? 0) &&
                productoDetalle.CIDVALORCARACTERISTICA2 == (valor2?.CIDVALORCARACTERISTICA ?? 0) &&
                productoDetalle.CIDVALORCARACTERISTICA3 == (valor3?.CIDVALORCARACTERISTICA ?? 0))
                switch (movimiento.CAFECTAEXISTENCIA)
                {
                    case 1:
                        entradas += movimiento.CUNIDADES;
                        break;
                    case 2:
                        salidas += movimiento.CUNIDADES;
                        break;
                }
        }

        return entradas - salidas;
    }
}
