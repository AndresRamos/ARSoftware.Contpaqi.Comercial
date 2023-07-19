using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosProducto
{
    private readonly ILogger<EjemplosProducto> _logger;
    private readonly IProductoRepository<admProductos> _productoRepository;

    public EjemplosProducto(IProductoRepository<admProductos> productoRepository, ILogger<EjemplosProducto> logger)
    {
        _productoRepository = productoRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de productos.");

        BuscarPorCodigo("PROD001");

        BuscarPorId(1);

        TraerPorTipo(TipoProducto.Servicio);

        TraerTodo();
    }

    private void BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("Buscando producto con código {Codigo}", codigo);

        long startTime = Stopwatch.GetTimestamp();

        admProductos? producto = _productoRepository.BuscarPorCodigo(codigo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (producto is not null)
            LogProducto(producto);
        else
            _logger.LogInformation("No se encontro el producto con código {Codigo}", codigo);
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando producto con id {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admProductos? producto = _productoRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (producto is not null)
            LogProducto(producto);
        else
            _logger.LogInformation("No se encontro el producto con id {Id}", id);
    }

    private void TraerPorTipo(TipoProducto tipoProducto)
    {
        _logger.LogInformation("Buscando productos con tipo {TipoProducto}", tipoProducto);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admProductos> productos = _productoRepository.TraerPorTipo(tipoProducto);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admProductos producto in productos) LogProducto(producto);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los productos.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admProductos> productos = _productoRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admProductos producto in productos) LogProducto(producto);
    }

    private void LogProducto(admProductos producto)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, Tipo: {Tipo}, ClaveSAT: {ClaveSat}", producto.CIDPRODUCTO,
            producto.CCODIGOPRODUCTO, producto.CNOMBREPRODUCTO, producto.CTIPOPRODUCTO, producto.CCLAVESAT);
    }
}