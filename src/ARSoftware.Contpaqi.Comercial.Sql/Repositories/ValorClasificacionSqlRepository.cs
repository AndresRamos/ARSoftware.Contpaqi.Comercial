using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ValorClasificacionSqlRepository : IValorClasificacionRepository<admClasificacionesValores>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ValorClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificacionesValores BuscarPorId(int idValorClasificacion)
    {
        return _context.admClasificacionesValores.SingleOrDefault(valor => valor.CIDVALORCLASIFICACION == idValorClasificacion);
    }

    /// <inheritdoc />
    public admClasificacionesValores BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion, string codigoValorClasificacion)
    {
        var repository = new ClasificacionSqlRepository(_context);

        admClasificaciones clasificacion = repository.BuscarPorTipoYNumero(tipoClasificacion, numeroClasificacion);

        return _context.admClasificacionesValores.SingleOrDefault(valor =>
            valor.CIDCLASIFICACION == clasificacion.CIDCLASIFICACION && valor.CCODIGOVALORCLASIFICACION == codigoValorClasificacion);
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerPorClasificacionId(int idClasificacion)
    {
        return _context.admClasificacionesValores.Where(valor => valor.CIDCLASIFICACION == idClasificacion);
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion)
    {
        var repository = new ClasificacionSqlRepository(_context);

        admClasificaciones clasificacion = repository.BuscarPorTipoYNumero(tipoClasificacion, numeroClasificacion);

        return _context.admClasificacionesValores.Where(valor => valor.CIDCLASIFICACION == clasificacion.CIDCLASIFICACION);
    }

    /// <inheritdoc />
    public IEnumerable<admClasificacionesValores> TraerTodo()
    {
        return _context.admClasificacionesValores.ToList();
    }
}