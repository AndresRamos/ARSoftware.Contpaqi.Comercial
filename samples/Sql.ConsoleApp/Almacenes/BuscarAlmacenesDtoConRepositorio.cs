using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarAlmacenesDtoConRepositorio : IBuscarAlmacenes
{
    private readonly IAlmacenRepository<AlmacenDto> _almacenRepository;
    private readonly ILogger<BuscarAlmacenesDtoConRepositorio> _logger;

    public BuscarAlmacenesDtoConRepositorio(IAlmacenRepository<AlmacenDto> almacenRepository,
        ILogger<BuscarAlmacenesDtoConRepositorio> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    //// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoAlmacen = "PRUEBA";

        AlmacenDto? almacen = _almacenRepository.BuscarPorCodigo(codigoAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void BuscarPorId()
    {
        var idAlmacen = 1;

        AlmacenDto? almacen = _almacenRepository.BuscarPorId(idAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void TraerTodo()
    {
        List<AlmacenDto> almacenes = _almacenRepository.TraerTodo();

        _logger.LogInformation("{@Almacenes}", almacenes);
    }
}
