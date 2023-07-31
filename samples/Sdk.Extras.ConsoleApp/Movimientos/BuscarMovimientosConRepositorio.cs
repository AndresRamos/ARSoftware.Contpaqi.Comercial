using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarMovimientosConRepositorio : IBuscarMovimientos
{
    private readonly ILogger<BuscarMovimientosConRepositorio> _logger;
    private readonly IMovimientoRepository<admMovimientos> _movimientoRepository;

    public BuscarMovimientosConRepositorio(IMovimientoRepository<admMovimientos> movimientoRepository,
        ILogger<BuscarMovimientosConRepositorio> logger)
    {
        _movimientoRepository = movimientoRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idMovimiento = 1;

        admMovimientos? movimiento = _movimientoRepository.BuscarPorId(idMovimiento);

        _logger.LogInformation("{@Movimiento}", movimiento);
    }

    /// <inheritdoc />
    public void TraerPorDocumentoId()
    {
        var idDocumento = 1;

        List<admMovimientos> movimientos = _movimientoRepository.TraerPorDocumentoId(idDocumento);

        _logger.LogInformation("{@Movimientos}", movimientos);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admMovimientos> movimientos = _movimientoRepository.TraerTodo();

        _logger.LogInformation("{@Movimientos}", movimientos);
    }
}
