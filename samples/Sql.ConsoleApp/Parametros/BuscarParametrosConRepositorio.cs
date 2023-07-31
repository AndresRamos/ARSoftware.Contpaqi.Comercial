using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp;

public sealed class BuscarParametrosConRepositorio : IBuscarParametros
{
    private readonly ILogger<BuscarParametrosConRepositorio> _logger;
    private readonly IParametrosRepository<admParametros> _parametrosRepository;

    public BuscarParametrosConRepositorio(IParametrosRepository<admParametros> parametrosRepository,
        ILogger<BuscarParametrosConRepositorio> logger)
    {
        _parametrosRepository = parametrosRepository;
        _logger = logger;
    }

    /// <inheritdoc />
    public void Buscar()
    {
        admParametros parametros = _parametrosRepository.Buscar();

        _logger.LogInformation("{@Parametros}", parametros);
    }
}
