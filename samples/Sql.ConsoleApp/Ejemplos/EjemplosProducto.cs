using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common.Models.Dtos;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosProducto
{
    private readonly ContpaqiComercialEmpresaDbContext _empresaDbContext;
    private readonly ILogger<EjemplosProducto> _logger;

    public EjemplosProducto(ContpaqiComercialEmpresaDbContext empresaDbContext, ILogger<EjemplosProducto> logger)
    {
        _empresaDbContext = empresaDbContext;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de productos.");

        BuscarTodosLosProductos();

        BuscarTodosLosProductosUtilizandoDto();
    }

    private void BuscarTodosLosProductos()
    {
        _logger.LogInformation("Buscando todos los productos.");
        long startTime = Stopwatch.GetTimestamp();
        List<admProductos> productos = _empresaDbContext.admProductos.OrderBy(p => p.CNOMBREPRODUCTO).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroProductos} productos.", productos.Count);
        foreach (admProductos producto in productos)
            LogProducto(producto);
    }

    private void BuscarTodosLosProductosUtilizandoDto()
    {
        _logger.LogInformation("Buscando todos los productos utilizando un DTO.");
        long startTime = Stopwatch.GetTimestamp();
        List<ProductoDto> productos = _empresaDbContext.admProductos.OrderBy(p => p.CNOMBREPRODUCTO)
            .Select(p => new ProductoDto
            {
                CIDPRODUCTO = p.CIDPRODUCTO,
                CCODIGOPRODUCTO = p.CCODIGOPRODUCTO,
                CNOMBREPRODUCTO = p.CNOMBREPRODUCTO,
                CTIPOPRODUCTO = p.CTIPOPRODUCTO,
                CCLAVESAT = p.CCLAVESAT
            })
            .ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroProductos} productos.", productos.Count);
        foreach (ProductoDto producto in productos)
            LogProducto(producto);
    }

    private void LogProducto(admProductos producto)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, Tipo: {Tipo}, ClaveSAT: {ClaveSat}",
            producto.CIDPRODUCTO,
            producto.CCODIGOPRODUCTO,
            producto.CNOMBREPRODUCTO,
            producto.CTIPOPRODUCTO,
            producto.CCLAVESAT);
    }

    private void LogProducto(ProductoDto producto)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, Tipo: {Tipo}, ClaveSAT: {ClaveSat}",
            producto.CIDPRODUCTO,
            producto.CCODIGOPRODUCTO,
            producto.CNOMBREPRODUCTO,
            producto.CTIPOPRODUCTO,
            producto.CCLAVESAT);
    }
}
