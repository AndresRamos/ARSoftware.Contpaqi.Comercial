using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAgenteDtoConRepositorio : IBuscarAgente
{
    private readonly AgenteSqlRepository<AgenteDto> _agenteRepository;
    private readonly ILogger<BuscarAgenteDtoConRepositorio> _logger;

    public BuscarAgenteDtoConRepositorio(AgenteSqlRepository<AgenteDto> agenteRepository, ILogger<BuscarAgenteDtoConRepositorio> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigo)
    {
        AgenteDto? agente = _agenteRepository.BuscarPorCodigo(codigo);

        if (agente is not null)
            _logger.LogInformation("{@Agente}", agente);
        else
            _logger.LogWarning("No se encontro el agente con codigo: {Codigo}", codigo);
    }

    public void BuscarPorId(int id)
    {
        AgenteDto? agente = _agenteRepository.BuscarPorId(id);

        if (agente is not null)
            _logger.LogInformation("{@Agente}", agente);
        else
            _logger.LogWarning("No se encontro el agente con Id: {Id}", id);
    }

    /// <inheritdoc />
    public void BuscarPorTipo(TipoAgente tipo)
    {
        List<AgenteDto> agentes = _agenteRepository.BuscarPorTipo(tipo);

        if (agentes.Any())
        {
            foreach (AgenteDto agente in agentes) _logger.LogInformation("{@Agente}", agente);
        }
        else
            _logger.LogWarning("No se encontraron agentes con Tipo: {TipoAgente}.", tipo);
    }

    public void TraerTodo()
    {
        List<AgenteDto> agentes = _agenteRepository.TraerTodo();

        if (agentes.Any())
        {
            foreach (AgenteDto agente in agentes) _logger.LogInformation("{@Agente}", agente);
        }
        else
            _logger.LogWarning("No se encontraron agentes.");
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de agentes.");

        //BuscarPorCodigo("01");

        //BuscarPorId(1);

        BuscarPorTipo(TipoAgente.VentasCobro);

        //TraerTodo();
    }
}