using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosAgente
{
    private readonly IAgenteRepository<admAgentes> _agenteRepository;
    private readonly ILogger<EjemplosAgente> _logger;

    public EjemplosAgente(IAgenteRepository<admAgentes> agenteRepository, ILogger<EjemplosAgente> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de agentes.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerTodo();
    }

    private void BuscarPorCodigo(string codigo)
    {
        _logger.LogInformation("Buscando agente con Codigo: {Codigo}.", codigo);

        long startTime = Stopwatch.GetTimestamp();

        admAgentes? agente = _agenteRepository.BuscarPorCodigo(codigo);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (agente is not null)
            LogAgente(agente);
        else
            _logger.LogInformation("No se encontro el agente con codigo: {Codigo}", codigo);
    }

    private void BuscarPorId(int id)
    {
        _logger.LogInformation("Buscando agente con Id: {Id}.", id);

        long startTime = Stopwatch.GetTimestamp();

        admAgentes? agente = _agenteRepository.BuscarPorId(id);

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        if (agente is not null)
            LogAgente(agente);
        else
            _logger.LogInformation("No se encontro el agente con Id: {Id}", id);
    }

    private void TraerTodo()
    {
        long startTime = Stopwatch.GetTimestamp();

        List<admAgentes> agentes = _agenteRepository.TraerTodo().ToList();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);

        _logger.LogInformation("Se encontraron {NumeroAgentes} agentes. La operacion tardo {Tiempo}", agentes.Count, elapsedTime);

        foreach (admAgentes agente in agentes) LogAgente(agente);
    }

    private void LogAgente(admAgentes agente)
    {
        _logger.LogInformation("Codigo: {Codigo}, Nombre: {Nombre}", agente.CCODIGOAGENTE, agente.CNOMBREAGENTE);
    }
}