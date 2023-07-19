using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosMoneda
{
    private readonly ILogger<EjemplosMoneda> _logger;
    private readonly IMonedaRepository<admMonedas> _monedaRepository;

    public EjemplosMoneda(IMonedaRepository<admMonedas> monedaRepository, ILogger<EjemplosMoneda> logger)
    {
        _monedaRepository = monedaRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de monedas.");

        BuscarPorId(1);

        BuscarPorNombre("Peso Mexicano");

        TraerTodo();
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando moneda con Id: {Id}", id);

        long startTime = Stopwatch.GetTimestamp();

        admMonedas? moneda = _monedaRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (moneda is not null)
            LogMoneda(moneda);
        else
            _logger.LogInformation("No se encontro la moneda con Id: {Id}", id);
    }

    private void BuscarPorNombre(string nombre)
    {
        _logger.LogInformation("Buscando moneda con Nombre: {Nombre}", nombre);

        long startTime = Stopwatch.GetTimestamp();

        admMonedas? moneda = _monedaRepository.BuscarPorNombre(nombre);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (moneda is not null)
            LogMoneda(moneda);
        else
            _logger.LogInformation("No se encontro la moneda con Nombre: {Nombre}", nombre);
    }

    private void TraerTodo()
    {
        _logger.LogInformation("Buscando todas las monedas.");

        long startTime = Stopwatch.GetTimestamp();

        IEnumerable<admMonedas> monedas = _monedaRepository.TraerTodo();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        foreach (admMonedas moneda in monedas) LogMoneda(moneda);
    }

    private void LogMoneda(admMonedas moneda)
    {
        _logger.LogInformation("Id: {Id}, Nombre: {Nombre}, Simbolo: {Simbolo}", moneda.CIDMONEDA, moneda.CNOMBREMONEDA,
            moneda.CSIMBOLOMONEDA);
    }
}