using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarProductosDtoConRepositorio : IBuscarProductos
{
    private readonly ILogger<BuscarProductosDtoConRepositorio> _logger;
    private readonly ProductoSqlRepository<ProductoDto> _productoRepository;

    public BuscarProductosDtoConRepositorio(ProductoSqlRepository<ProductoDto> productoRepository,
        ILogger<BuscarProductosDtoConRepositorio> logger)
    {
        _productoRepository = productoRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoProducto)
    {
        ProductoDto? producto = _productoRepository.BuscarPorCodigo(codigoProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    public void BuscarPorId(int idProducto)
    {
        ProductoDto? producto = _productoRepository.BuscarPorId(idProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    public void TraerPorTipo(TipoProducto tipoProducto)
    {
        List<ProductoDto> productos = _productoRepository.TraerPorTipo(tipoProducto);

        _logger.LogInformation("{@Productos}", productos);
    }

    public void TraerTodo()
    {
        List<ProductoDto> productos = _productoRepository.TraerTodo();

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