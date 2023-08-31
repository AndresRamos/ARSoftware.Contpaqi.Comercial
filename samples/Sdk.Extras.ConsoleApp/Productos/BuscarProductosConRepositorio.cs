using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarProductosConRepositorio : IBuscarProductos
{
    private readonly ILogger<BuscarProductosConRepositorio> _logger;
    private readonly IProductoRepository<admProductos> _productoRepository;

    public BuscarProductosConRepositorio(IProductoRepository<admProductos> productoRepository,
        ILogger<BuscarProductosConRepositorio> logger)
    {
        _productoRepository = productoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoProducto = "PRUEBA";

        admProductos? producto = _productoRepository.BuscarPorCodigo(codigoProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idProducto = 1;

        admProductos? producto = _productoRepository.BuscarPorId(idProducto);

        _logger.LogInformation("{@Producto}", producto);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoProducto = TipoProducto.Servicio;

        List<admProductos> productos = _productoRepository.TraerPorTipo(tipoProducto);

        _logger.LogInformation("{@Productos}", productos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admProductos> productos = _productoRepository.TraerTodo();

        _logger.LogInformation("{@Productos}", productos);
    }

    public void BuscaExistencias()
    {
        var codigoProducto = "PRUEBA";
        var codigoAlmacen = "PRUEBA";
        var fecha = new DateOnly(2023, 1, 1);

        double existencias = _productoRepository.BuscaExistencias(codigoProducto, codigoAlmacen, fecha);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }

    public void BuscaExistenciasConCaracteristicas()
    {
        var codigoProducto = "PRUEBA";
        var codigoAlmacen = "PRUEBA";
        var fecha = new DateOnly(2023, 1, 1);
        var valorCaracteristica1 = "CARACTERISTICA1";
        var valorCaracteristica2 = "CARACTERISTICA2";
        var valorCaracteristica3 = "CARACTERISTICA3";

        double existencias = _productoRepository.BuscaExistenciasConCaracteristicas(codigoProducto, codigoAlmacen, fecha,
            valorCaracteristica1, valorCaracteristica2, valorCaracteristica3);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }

    public void BuscaExistenciasConCapas()
    {
        var codigoProducto = "PRUEBA";
        var codigoAlmacen = "PRUEBA";
        var pedimento = "11 11 1111 111111";
        var lote = "1234";

        double existencias = _productoRepository.BuscaExistenciasConCapas(codigoProducto, codigoAlmacen, pedimento, lote);

        _logger.LogInformation("Existencias: {Existencias}", existencias);
    }
}
