using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarAgentesDtoConRepositorio : IBuscarAgentes
{
    private readonly IAgenteRepository<AgenteDto> _agenteRepository;
    private readonly ILogger<BuscarAgentesDtoConRepositorio> _logger;

    public BuscarAgentesDtoConRepositorio(IAgenteRepository<AgenteDto> agenteRepository, ILogger<BuscarAgentesDtoConRepositorio> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void BuscarPorCodigo()
    {
        var codigoAgente = "PRUEBA";

        AgenteDto? agente = _agenteRepository.BuscarPorCodigo(codigoAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void BuscarPorId()
    {
        var idAgente = 1;

        AgenteDto? agente = _agenteRepository.BuscarPorId(idAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void TraerPorTipo()
    {
        var tipoAgente = TipoAgente.VentasCobro;

        List<AgenteDto> agentes = _agenteRepository.TraerPorTipo(tipoAgente);

        _logger.LogInformation("{@Agentes}", agentes);
    }

    /// <inheritdoc />
    public void TraerTodo()
    {
        List<AgenteDto> agentes = _agenteRepository.TraerTodo();

        _logger.LogInformation("{@Agentes}", agentes);
    }
}
