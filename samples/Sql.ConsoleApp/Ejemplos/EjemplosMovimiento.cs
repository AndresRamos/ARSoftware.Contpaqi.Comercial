using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosMovimiento
{
    private readonly ILogger<EjemplosMovimiento> _logger;
    private readonly IMovimientoRepository<admMovimientos> _movimientoRepository;

    public EjemplosMovimiento(IMovimientoRepository<admMovimientos> movimientoRepository, ILogger<EjemplosMovimiento> logger)
    {
        _movimientoRepository = movimientoRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de movimientos.");

        BuscarPorId(1);

        TraerPorDocumentoId(1);

        TraerTodo();
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando movimiento con Id: {Id}.", id);

        long startTime = Stopwatch.GetTimestamp();

        admMovimientos? movimiento = _movimientoRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (movimiento is not null)
            LogMovimiento(movimiento);
        else
            _logger.LogInformation("No se encontro el movimiento con Id: {Id}", id);
    }

    private void TraerPorDocumentoId(int idDocumento)
    {
        _logger.LogInformation("Buscando movimientos con IdDocumento: {IdDocumento}.", idDocumento);

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admMovimientos> movimientos = _movimientoRepository.TraerPorDocumentoId(idDocumento);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admMovimientos movimiento in movimientos) LogMovimiento(movimiento);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todos los movimientos.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admMovimientos> movimientos = _movimientoRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admMovimientos movimiento in movimientos) LogMovimiento(movimiento);
    }

    private void LogMovimiento(admMovimientos movimiento)
    {
        _logger.LogInformation(
            "DocumentoId: {DocumentoId}, ProductoId: {ProductoId}, Unidades: {Unidades}, Precio: {Precio:C}, Iva: {Iva}%, Total: {Total:C}",
            movimiento.CIDDOCUMENTO, movimiento.CIDPRODUCTO, movimiento.CUNIDADES, movimiento.CPRECIO, movimiento.CPORCENTAJEIMPUESTO1,
            movimiento.CTOTAL);
    }
}