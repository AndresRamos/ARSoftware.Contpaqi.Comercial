using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarMovimientosConRepositorio : IBuscarMovimientos
{
    private readonly ILogger<BuscarMovimientosConRepositorio> _logger;
    private readonly MovimientoSqlRepository _movimientoRepository;

    public BuscarMovimientosConRepositorio(MovimientoSqlRepository movimientoRepository, ILogger<BuscarMovimientosConRepositorio> logger)
    {
        _movimientoRepository = movimientoRepository;
        _logger = logger;
    }

    public void BuscarPorId(int idMovimiento)
    {
        admMovimientos? movimiento = _movimientoRepository.BuscarPorId(idMovimiento);

        _logger.LogInformation("{@Movimiento}", movimiento);
    }

    public void TraerPorDocumentoId(int idDocumento)
    {
        List<admMovimientos> movimientos = _movimientoRepository.TraerPorDocumentoId(idDocumento);

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    public void TraerTodo()
    {
        List<admMovimientos> movimientos = _movimientoRepository.TraerTodo();

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    public void CorrerEjemplos()
    {
        BuscarPorId(1);

        TraerPorDocumentoId(1);

        TraerTodo();
    }
}