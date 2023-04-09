using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Sdk.Extras.ConsoleApp.Dtos;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosProducto
{
    private const string CodigoPruebas = "PRODPRUEBA";
    private const string NombrePruebas = "PRODUCTO PRUEBAS";
    private const string ClaveSatPruebas = "81111504";
    private const TipoProducto Tipo = TipoProducto.Producto;
    private readonly ILogger<EjemplosProducto> _logger;
    private readonly IProductoRepository<ProductoDto> _productoDtoRepository;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IProductoService _productoService;

    public EjemplosProducto(IProductoRepository<Producto> productoRepository,
                            IProductoService productoService,
                            ILogger<EjemplosProducto> logger,
                            IProductoRepository<ProductoDto> productoDtoRepository)
    {
        _productoRepository = productoRepository;
        _productoService = productoService;
        _logger = logger;
        _productoDtoRepository = productoDtoRepository;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de productos.");

        int productoId = CrearProductoPrueba();

        BuscarProductoPorId(productoId);

        ModificarProductoPrueba();

        BuscarProductoPorCodigo(CodigoPruebas);

        BuscarTodosLosProductos();

        BuscarTodosLosProductosUtilizandoDto();

        BuscarProductosPorTipo(TipoProducto.Servicio);

        EliminarProductoPrueba();
    }

    private void BuscarProductoPorId(int productoId)
    {
        _logger.LogInformation("Buscando producto por id: {ProductoId}", productoId);
        long startTime = Stopwatch.GetTimestamp();
        Producto? producto = _productoRepository.BuscarPorId(productoId);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (producto is not null)
            LogProducto(producto);
        else
            _logger.LogInformation("No se encontro el producto con id {ProductoId}", productoId);
    }

    private void BuscarProductoPorCodigo(string productoCodigo)
    {
        _logger.LogInformation("Buscando producto por id: {ProductoCodigo}", productoCodigo);
        long startTime = Stopwatch.GetTimestamp();
        Producto? producto = _productoRepository.BuscarPorCodigo(productoCodigo);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        if (producto is not null)
            LogProducto(producto);
        else
            _logger.LogInformation("No se encontro el producto con id {ProductoCodigo}", productoCodigo);
    }

    private void BuscarProductosPorTipo(TipoProducto tipo)
    {
        _logger.LogInformation("Buscando productos por tipo {Tipo}", tipo);
        long startTime = Stopwatch.GetTimestamp();
        List<Producto> productos = _productoRepository.TraerPorTipo(tipo).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroProductos} productos.", productos.Count);
        foreach (Producto? producto in productos)
            LogProducto(producto);
    }

    private void BuscarTodosLosProductos()
    {
        _logger.LogInformation("Buscando todos los productos.");
        long startTime = Stopwatch.GetTimestamp();
        List<Producto> productos = _productoRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroProductos} productos.", productos.Count);
        foreach (Producto? producto in productos)
            LogProducto(producto);
    }

    private void BuscarTodosLosProductosUtilizandoDto()
    {
        _logger.LogInformation("Buscando todos los productos utilizando un DTO.");
        long startTime = Stopwatch.GetTimestamp();
        List<ProductoDto> productos = _productoDtoRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroProductos} productos.", productos.Count);
        foreach (ProductoDto? producto in productos)
            LogProducto(producto);
    }

    private int CrearProductoPrueba()
    {
        _logger.LogInformation("Creando producto.");
        var producto = new Producto();
        producto.Tipo = Tipo;
        producto.CCODIGOPRODUCTO = CodigoPruebas;
        producto.CNOMBREPRODUCTO = NombrePruebas;
        tProducto productoSdk = producto.ToTProducto();
        long startTime = Stopwatch.GetTimestamp();
        int productoId = _productoService.Crear(productoSdk);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        return productoId;
    }

    private void ModificarProductoPrueba()
    {
        _logger.LogInformation("Modificando producto.");
        var datosProducto = new Dictionary<string, string>
        {
            { nameof(admProductos.CCLAVESAT), ClaveSatPruebas }, { nameof(admProductos.CNOMBREPRODUCTO), NombrePruebas }
        };
        long startTime = Stopwatch.GetTimestamp();
        _productoService.Actualizar(CodigoPruebas, datosProducto);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void EliminarProductoPrueba()
    {
        _logger.LogInformation("Eliminando producto.");
        long startTime = Stopwatch.GetTimestamp();
        _productoService.Eliminar(CodigoPruebas);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void LogProducto(Producto producto)
    {
        _logger.LogInformation("Id: {Id}, Codigo: {Codigo}, Nombre: {Nombre}, Tipo: {Tipo}, ClaveSAT: {ClaveSat}",
            producto.CIDPRODUCTO,
            producto.CCODIGOPRODUCTO,
            producto.CNOMBREPRODUCTO,
            producto.Tipo,
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
