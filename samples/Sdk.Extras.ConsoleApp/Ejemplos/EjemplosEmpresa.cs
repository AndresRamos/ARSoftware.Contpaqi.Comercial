using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosEmpresa
{
    public const string NombreEmpresaPruebas = "UNIVERSIDAD ROBOTICA ESPAÑOLA SA DE CV";
    private readonly IEmpresaRepository<Empresa> _empresaRepository;
    private readonly ILogger<EjemplosEmpresa> _logger;

    public EjemplosEmpresa(IEmpresaRepository<Empresa> empresaRepository, ILogger<EjemplosEmpresa> logger)
    {
        _empresaRepository = empresaRepository;
        _logger = logger;
    }

    public void CorrerEjemplos()
    {
        // Comenta los ejemplos que no quieras ejecutar

        _logger.LogInformation("Corriendo pruebas de empresas.");

        BuscarTodasLasEmpresas();

        BuscarEmpresaPorNombre(NombreEmpresaPruebas);
    }

    private void BuscarTodasLasEmpresas()
    {
        _logger.LogInformation("Buscando todas las empresas.");
        long startTime = Stopwatch.GetTimestamp();
        List<Empresa> empresas = _empresaRepository.TraerTodo().ToList();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
        _logger.LogInformation("Se encontraron {NumeroEmpresas} empresas.", empresas.Count);
        foreach (Empresa empresa in empresas) LogEmpresa(empresa);
    }

    private Empresa BuscarEmpresaPorNombre(string nombreEmpresa)
    {
        _logger.LogInformation("Buscando empresa por nombre: {NombreEmpresa}", nombreEmpresa);
        Empresa empresa = _empresaRepository.TraerTodo().FirstOrDefault(x => x.CNOMBREEMPRESA == nombreEmpresa) ??
                          throw new InvalidOperationException($"No se encontro la empresa con nombre: {NombreEmpresaPruebas}");
        LogEmpresa(empresa);
        return empresa;
    }

    public Empresa BuscarEmpresaPrueba()
    {
        return BuscarEmpresaPorNombre(NombreEmpresaPruebas);
    }

    private void LogEmpresa(Empresa empresa)
    {
        _logger.LogInformation("Id: {Id}, Nombre: {Nombre}, Ruta: {Ruta}", empresa.CIDEMPRESA, empresa.CNOMBREEMPRESA, empresa.CRUTADATOS);
    }
}