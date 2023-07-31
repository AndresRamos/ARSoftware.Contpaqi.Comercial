using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarAlmacenesConRepositorio : IBuscarAlmacenes
{
    private readonly IAlmacenRepository<admAlmacenes> _almacenRepository;
    private readonly ILogger<BuscarAlmacenesConRepositorio> _logger;

    public BuscarAlmacenesConRepositorio(IAlmacenRepository<admAlmacenes> almacenRepository, ILogger<BuscarAlmacenesConRepositorio> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoAlmacen = "PRUEBA";

        admAlmacenes? almacen = _almacenRepository.BuscarPorCodigo(codigoAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idAlmacen = 1;

        admAlmacenes? almacen = _almacenRepository.BuscarPorId(idAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admAlmacenes> almacenes = _almacenRepository.TraerTodo();

        _logger.LogInformation("{@Almacenes}", almacenes);
    }
}
