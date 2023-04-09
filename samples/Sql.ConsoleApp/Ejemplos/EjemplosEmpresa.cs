using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using Microsoft.Extensions.Logging;

namespace Sql.ConsoleApp.Ejemplos;

public sealed class EjemplosEmpresa
{
    private readonly ContpaqiComercialGeneralesDbContext _generalesDbContext;
    private readonly ILogger<EjemplosEmpresa> _logger;

    public EjemplosEmpresa(ContpaqiComercialGeneralesDbContext generalesDbContext, ILogger<EjemplosEmpresa> logger)
    {
        _generalesDbContext = generalesDbContext;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de empresas.");

        BuscarTodasLasEmpresas();
    }

    private IEnumerable<Empresas> BuscarTodasLasEmpresas()
    {
        _logger.LogInformation("Buscando todas las empresas.");
        long startTime = Stopwatch.GetTimestamp();
        List<Empresas> empresas = _generalesDbContext.Empresas.OrderBy(e => e.CNOMBREEMPRESA).ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroEmpresas} empresas.", empresas.Count);
        foreach (Empresas empresa in empresas)
            LogEmpresa(empresa);

        return empresas;
    }

    private void LogEmpresa(Empresas empresa)
    {
        _logger.LogInformation("Id: {Id}, Nombre: {Nombre}, Ruta: {Ruta}", empresa.CIDEMPRESA, empresa.CNOMBREEMPRESA, empresa.CRUTADATOS);
    }
}
