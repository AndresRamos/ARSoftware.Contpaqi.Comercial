using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarProductosConRepositorio : IBuscarProductos
{
    private readonly ILogger<BuscarProductosConRepositorio> _logger;
    private readonly ProductoSqlRepository _productoRepository;

    public BuscarProductosConRepositorio(ProductoSqlRepository productoRepository, ILogger<BuscarProductosConRepositorio> logger)
    {
        _productoRepository = productoRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoProducto)
    {
        admProductos? producto = _productoRepository.BuscarPorCodigo(codigoProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    public void BuscarPorId(int idProducto)
    {
        admProductos? producto = _productoRepository.BuscarPorId(idProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    public void TraerPorTipo(TipoProducto tipoProducto)
    {
        List<admProductos> productos = _productoRepository.TraerPorTipo(tipoProducto);

        _logger.LogInformation("{@Productos}", productos);
    }

    public void TraerTodo()
    {
        List<admProductos> productos = _productoRepository.TraerTodo();

        _logger.LogInformation("{@Productos}", productos);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("PROD001");

        BuscarPorId(1);

        TraerPorTipo(TipoProducto.Servicio);

        TraerTodo();
    }
}