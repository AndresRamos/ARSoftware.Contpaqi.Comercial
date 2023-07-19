using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosEmpresa
{
    private readonly IEmpresaRepository<Empresas> _empresaRepository;
    private readonly ILogger<EjemplosEmpresa> _logger;

    public EjemplosEmpresa(IEmpresaRepository<Empresas> empresaRepository, ILogger<EjemplosEmpresa> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo ejemplos de empresas.");

        BuscarTodasLasEmpresas();
    }

    /// <summary>
    ///     Busca todas las empresas.
    /// </summary>
    /// <returns>Las empresas encontradas.</returns>
    private IEnumerable<Empresas> BuscarTodasLasEmpresas()
    {
        _logger.LogInformation("Buscando todas las empresas.");

        long startTime = Stopwatch.GetTimestamp();

        List<Empresas> empresas = _empresaRepository.TraerTodo().ToList();

        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);

        _logger.LogInformation("Se encontraron {NumeroEmpresas} empresas.", empresas.Count);

        foreach (Empresas empresa in empresas) LogEmpresa(empresa);

        return empresas;
    }

    private void LogEmpresa(Empresas empresa)
    {
        _logger.LogInformation("Id: {Id}, Nombre: {Nombre}, Ruta: {Ruta}, BaseDatos: {BaseDatos}", empresa.CIDEMPRESA,
            empresa.CNOMBREEMPRESA, empresa.CRUTADATOS, new DirectoryInfo(empresa.CRUTADATOS).Name);
    }
}