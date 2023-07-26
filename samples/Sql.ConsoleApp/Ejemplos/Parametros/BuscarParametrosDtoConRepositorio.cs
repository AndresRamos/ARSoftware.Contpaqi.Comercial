using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models.Dtos;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarParametrosDtoConRepositorio : IBuscarParametros
{
    private readonly ILogger<BuscarParametrosDtoConRepositorio> _logger;
    private readonly ParametrosSqlRepository<ParametrosDto> _parametrosRepository;

    public BuscarParametrosDtoConRepositorio(ParametrosSqlRepository<ParametrosDto> parametrosRepository,
        ILogger<BuscarParametrosDtoConRepositorio> logger)
    {
        _parametrosRepository = parametrosRepository;
        _logger = logger;
    }

    public void Buscar()
    {
        ParametrosDto parametros = _parametrosRepository.Buscar();

        _logger.LogInformation("{@Parametros}", parametros);
    }

    public void CorrerEjemplos()
    {
        Buscar();
    }
}