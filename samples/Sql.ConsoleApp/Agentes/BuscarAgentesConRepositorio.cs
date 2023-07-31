using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarAgentesConRepositorio : IBuscarAgentes
{
    private readonly IAgenteRepository<admAgentes> _agenteRepository;
    private readonly ILogger<BuscarAgentesConRepositorio> _logger;

    public BuscarAgentesConRepositorio(IAgenteRepository<admAgentes> agenteRepository, ILogger<BuscarAgentesConRepositorio> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoAgente = "1";

        admAgentes? agente = _agenteRepository.BuscarPorCodigo(codigoAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idAgente = 1;

        admAgentes? agente = _agenteRepository.BuscarPorId(idAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoAgente = TipoAgente.VentasCobro;

        List<admAgentes> agentes = _agenteRepository.TraerPorTipo(tipoAgente);

        _logger.LogInformation("{@Agentes}", agentes);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<admAgentes> agentes = _agenteRepository.TraerTodo();

        _logger.LogInformation("{@Agentes}", agentes);
    }
}
