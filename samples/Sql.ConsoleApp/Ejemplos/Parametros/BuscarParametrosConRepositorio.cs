using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories;
using Microsoft.Extensions.Logging;
using Samples.Common;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class BuscarParametrosConRepositorio : IBuscarParametros
{
    private readonly ILogger<BuscarParametrosConRepositorio> _logger;
    private readonly ParametrosSqlRepository _parametrosRepository;

    public BuscarParametrosConRepositorio(ParametrosSqlRepository parametrosRepository, ILogger<BuscarParametrosConRepositorio> logger)
    {
        _parametrosRepository = parametrosRepository;
        _logger = logger;
    }

    public void Buscar()
    {
        admParametros parametros = _parametrosRepository.Buscar();

        _logger.LogInformation("{@Parametros}", parametros);
    }

    public void CorrerEjemplos()
    {
        Buscar();
    }
}