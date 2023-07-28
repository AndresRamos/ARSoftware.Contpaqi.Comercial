using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAlmacenesDtoConRepositorio : IBuscarAlmacenes
{
    private readonly AlmacenSqlRepository<AlmacenDto> _almacenRepository;
    private readonly ILogger<BuscarAlmacenesDtoConRepositorio> _logger;

    public BuscarAlmacenesDtoConRepositorio(AlmacenSqlRepository<AlmacenDto> almacenRepository,
        ILogger<BuscarAlmacenesDtoConRepositorio> logger)
    {
        _almacenRepository = almacenRepository;
        _logger = logger;
    }

    //// <inheritdoc />
    public void BuscarPorCodigo(string codigoAlmacen)
    {
        AlmacenDto? almacen = _almacenRepository.BuscarPorCodigo(codigoAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void BuscarPorId(int idAlmacen)
    {
        AlmacenDto? almacen = _almacenRepository.BuscarPorId(idAlmacen);

        _logger.LogInformation("{@Almacen}", almacen);
    }

    //// <inheritdoc />
    public void TraerTodo()
    {
        List<AlmacenDto> almacenes = _almacenRepository.TraerTodo();

        _logger.LogInformation("{@Almacenes}", almacenes);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerTodo();
    }
}