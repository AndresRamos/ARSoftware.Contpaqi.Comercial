using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sdk.Extras.ConsoleApp;

public sealed class BuscarParametrosDtoConRepositorio : IBuscarParametros
{
    private readonly ILogger<BuscarParametrosDtoConRepositorio> _logger;
    private readonly IParametrosRepository<ParametrosDto> _parametrosRepository;

    public BuscarParametrosDtoConRepositorio(IParametrosRepository<ParametrosDto> parametrosRepository,
        ILogger<BuscarParametrosDtoConRepositorio> logger)
    {
        _parametrosRepository = parametrosRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void Buscar()
    {
        ParametrosDto parametros = _parametrosRepository.Buscar();

        _logger.LogInformation("{@Parametros}", parametros);
    }
}
