using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarMovimientosDtoConRepositorio : IBuscarMovimientos
{
    private readonly ILogger<BuscarMovimientosDtoConRepositorio> _logger;
    private readonly MovimientoSqlRepository<MovimientoDto> _movimientoRepository;

    public BuscarMovimientosDtoConRepositorio(MovimientoSqlRepository<MovimientoDto> movimientoRepository,
        ILogger<BuscarMovimientosDtoConRepositorio> logger)
    {
        _movimientoRepository = movimientoRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idMovimiento)
    {
        MovimientoDto? movimiento = _movimientoRepository.BuscarPorId(idMovimiento);

        _logger.LogInformation("{@Movimiento}", movimiento);
    }

    public void TraerPorDocumentoId(int idDocumento)
    {
        List<MovimientoDto> movimientos = _movimientoRepository.TraerPorDocumentoId(idDocumento);

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    public void TraerTodo()
    {
        List<MovimientoDto> movimientos = _movimientoRepository.TraerTodo();

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        TraerPorDocumentoId(1);

        TraerTodo();
    }
}