using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosParametros
{
    private readonly ILogger<EjemplosParametros> _logger;
    private readonly IParametrosRepository<admParametros> _parametrosRepository;

    public EjemplosParametros(IParametrosRepository<admParametros> parametrosRepository, ILogger<EjemplosParametros> logger)
    {
        _parametrosRepository = parametrosRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de parametros.");

        Buscar();
    }

    private void Buscar()
    {
        _logger.LogInformation("Bucando Parametros");

        long startTime = Stopwatch.GetTimestamp();

        admParametros? parametros = _parametrosRepository.Buscar();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        LogParametros(parametros);
    }

    private void LogParametros(admParametros parametros)
    {
        _logger.LogInformation("Nombre: {NombreEmpresa}, RFC: {RfcEmpresa}, GuidEmpresa: {GuidEmpresa}, GuidAdd: {GuidAdd}",
            parametros.CNOMBREEMPRESA, parametros.CRFCEMPRESA, parametros.CGUIDEMPRESA, parametros.CGUIDDSL);
    }
}