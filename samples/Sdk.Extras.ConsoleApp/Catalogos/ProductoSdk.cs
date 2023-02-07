using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Catalogos;

public sealed class ProductoSdk
{
    private readonly ILogger<ProductoSdk> _logger;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IProductoService _productoService;

    public ProductoSdk(IProductoRepository<Producto> productoRepository, IProductoService productoService, ILogger<ProductoSdk> logger)
    {
        _productoRepository = productoRepository;
        _productoService = productoService;
        _logger = logger;
    }

    public IEnumerable<Producto> BuscarTodo()
    {
        _logger.LogInformation("BuscarTodo()");
        return _productoRepository.TraerTodo().ToList();
    }

    public IEnumerable<Producto> BuscarPorTipo(TipoProducto tipo)
    {
        _logger.LogInformation("BuscarPorTipo({tipo})", tipo);
        return _productoRepository.TraerPorTipo(tipo);
    }

    public Producto BuscarPorId(int id)
    {
        _logger.LogInformation("BuscarPorId({id})", id);
        return _productoRepository.BuscarPorId(id);
    }

    public Producto BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("BuscarPorCodigo({codigo})", codigo);
        return _productoRepository.BuscarPorCodigo(codigo);
    }

    public int CrearProductoPrueba()
    {
        _logger.LogInformation("CrearProductoPrueba()");
        var productoPrueba = new Producto();
        productoPrueba.Tipo = TipoProducto.Servicio;
        productoPrueba.CCODIGOPRODUCTO = "PRODPRUEBA";
        productoPrueba.CNOMBREPRODUCTO = "PRODUCTO PRUEBAS";

        int idNuevoProducto = _productoService.Crear(productoPrueba.ToTProducto());
        return idNuevoProducto;
    }

    public void ModificarProductoPrueba()
    {
        _logger.LogInformation("ModificarProductoPrueba()");
        var datosProducto = new Dictionary<string, string>
        {
            { nameof(admProductos.CCLAVESAT), "81111504" }, { nameof(admProductos.CNOMBREPRODUCTO), "PRODUCTO DE PRUEBAS COMERCIAL" }
        };
        _productoService.Actualizar("PRODPRUEBA", datosProducto);
    }

    public void EliminarProductoPrueba()
    {
        _logger.LogInformation("EliminarProductoPrueba()");
        _productoService.Eliminar("PRODPRUEBA");
    }

    public void LogProductos(IEnumerable<Producto> productos)
    {
        _logger.LogInformation("PRODUCTOS: #{NumeroProductos}", productos.Count());
        foreach (Producto producto in productos)
            LogProducto(producto);
    }

    public void LogProducto(Producto producto)
    {
        _logger.LogInformation("{Id} - {Codigo} - {Nombre} - {Tipo} - {ClaveSat}",
            producto.CIDPRODUCTO,
            producto.CCODIGOPRODUCTO,
            producto.CNOMBREPRODUCTO,
            producto.Tipo,
            producto.CCLAVESAT);
    }
}
