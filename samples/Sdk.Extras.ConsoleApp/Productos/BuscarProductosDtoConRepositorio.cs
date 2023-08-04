using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarProductosDtoConRepositorio : IBuscarProductos
{
    private readonly ILogger<BuscarProductosDtoConRepositorio> _logger;
    private readonly IProductoRepository<ProductoDto> _productoRepository;

    public BuscarProductosDtoConRepositorio(IProductoRepository<ProductoDto> productoRepository,
        ILogger<BuscarProductosDtoConRepositorio> logger)
    {
        _productoRepository = productoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoProducto = "PRUEBA";

        ProductoDto? producto = _productoRepository.BuscarPorCodigo(codigoProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idProducto = 1;

        ProductoDto? producto = _productoRepository.BuscarPorId(idProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoProducto = TipoProducto.Servicio;

        List<ProductoDto> productos = _productoRepository.TraerPorTipo(tipoProducto);

        _logger.LogInformation("{@Productos}", productos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<ProductoDto> productos = _productoRepository.TraerTodo();

        _logger.LogInformation("{@Productos}", productos);
    }
}
