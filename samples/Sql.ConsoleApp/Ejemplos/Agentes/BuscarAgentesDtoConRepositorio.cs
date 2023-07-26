using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarAgentesDtoConRepositorio : IBuscarAgentes
{
    private readonly AgenteSqlRepository<AgenteDto> _agenteRepository;
    private readonly ILogger<BuscarAgentesDtoConRepositorio> _logger;

    public BuscarAgentesDtoConRepositorio(AgenteSqlRepository<AgenteDto> agenteRepository, ILogger<BuscarAgentesDtoConRepositorio> logger)
    {
        _agenteRepository = agenteRepository;
        _logger = logger;
    }

    public void BuscarPorCodigo(string codigoAgente)
    {
        AgenteDto? agente = _agenteRepository.BuscarPorCodigo(codigoAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    public void BuscarPorId(int idAgente)
    {
        AgenteDto? agente = _agenteRepository.BuscarPorId(idAgente);

        _logger.LogInformation("{@Agente}", agente);
    }

    /// <inheritdoc />
    public void TraerPorTipo(TipoAgente tipoAgente)
    {
        List<AgenteDto> agentes = _agenteRepository.TraerPorTipo(tipoAgente);

        _logger.LogInformation("{@Agentes}", agentes);
    }

    public void TraerTodo()
    {
        List<AgenteDto> agentes = _agenteRepository.TraerTodo();

        _logger.LogInformation("{@Agentes}", agentes);
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de agentes.");

        BuscarPorCodigo("01");

        BuscarPorId(1);

        TraerPorTipo(TipoAgente.VentasCobro);

        TraerTodo();
    }
}