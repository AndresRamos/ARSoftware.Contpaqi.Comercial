using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAgentesConRepositorio : IBuscarAgentes
{
    private readonly AgenteSqlRepository _agenteRepository;
    private readonly ILogger<BuscarAgentesConRepositorio> _logger;

    public BuscarAgentesConRepositorio(AgenteSqlRepository agenteRepository, ILogger<BuscarAgentesConRepositorio> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoAgente)
    {
        admAgentes? agente = _agenteRepository.BuscarPorCodigo(codigoAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    public void BuscarPorId(int idAgente)
    {
        admAgentes? agente = _agenteRepository.BuscarPorId(idAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void TraerPorTipo(TipoAgente tipoAgente)
    {
        List<admAgentes> agentes = _agenteRepository.TraerPorTipo(tipoAgente);

        _logger.LogInformation("{@Agentes}", agentes);
    }

    public void TraerTodo()
    {
        List<admAgentes> agentes = _agenteRepository.TraerTodo();

        _logger.LogInformation("{@Agentes}", agentes);
    }

    public void CorrerEjemplos()
    {
        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerPorTipo(TipoAgente.Ventas);

        TraerTodo();
    }
}