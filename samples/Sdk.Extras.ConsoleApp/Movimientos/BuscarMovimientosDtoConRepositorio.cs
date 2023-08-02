using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarMovimientosDtoConRepositorio : IBuscarMovimientos
{
    private readonly ILogger<BuscarMovimientosDtoConRepositorio> _logger;
    private readonly IMovimientoRepository<MovimientoDto> _movimientoRepository;

    public BuscarMovimientosDtoConRepositorio(IMovimientoRepository<MovimientoDto> movimientoRepository,
        ILogger<BuscarMovimientosDtoConRepositorio> logger)
    {
        _movimientoRepository = movimientoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idMovimiento = 1;

        MovimientoDto? movimiento = _movimientoRepository.BuscarPorId(idMovimiento);

        _logger.LogInformation("{@Movimiento}", movimiento);
    }

    /// <inheritdoc />
    public void TraerPorDocumentoId()
    {
        var idDocumento = 1;

        List<MovimientoDto> movimientos = _movimientoRepository.TraerPorDocumentoId(idDocumento);

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<MovimientoDto> movimientos = _movimientoRepository.TraerTodo();

        _logger.LogInformation("{@Movimientos}", movimientos);
    }
}
