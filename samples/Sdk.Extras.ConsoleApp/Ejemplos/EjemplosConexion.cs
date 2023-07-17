using System.Diagnostics;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp.Ejemplos;

public sealed class EjemplosConexion
{
    public const string UsuarioPruebas = "SUPERVISOR";
    public const string ContrasenaPruebas = "";
    private readonly IEmpresaRepository<Empresa> _empresaRepository;
    private readonly ILogger<EjemplosConexion> _logger;
    private readonly IContpaqiSdk _sdk;
    private readonly IComercialSdkSesionService _sdkSesionService;

    public EjemplosConexion(IComercialSdkSesionService sdkSesionService, ILogger<EjemplosConexion> logger,
        IEmpresaRepository<Empresa> empresaRepository, IContpaqiSdk sdk)
    {
        _sdkSesionService = sdkSesionService;
        _logger = logger;
        _empresaRepository = empresaRepository;
        _sdk = sdk;
    }

    public void IniciarConexion()
    {
        if (_sdk is FacturaElectronicaSdkExtended || _sdk is AdminpaqSdkExtended)
            IniciarConexionSinParametros();
        else if (_sdk is ComercialSdkExtended) IniciarConexionConParametros(UsuarioPruebas, ContrasenaPruebas);
    }

    private void IniciarConexionSinParametros()
    {
        _logger.LogInformation("Iniciando conexion sin parametros.");
        long startTime = Stopwatch.GetTimestamp();
        _sdkSesionService.IniciarSesionSdk();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private void IniciarConexionConParametros(string usuario, string contrasena)
    {
        _logger.LogInformation("Iniciando conexion con parametros.");
        long startTime = Stopwatch.GetTimestamp();
        _sdkSesionService.IniciarSesionSdk(usuario, contrasena);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    public void TerminarConexion()
    {
        if (!_sdkSesionService.IsSdkInicializado) return;

        _logger.LogInformation("Terminando conexion.");
        long startTime = Stopwatch.GetTimestamp();
        _sdkSesionService.TerminarSesionSdk();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    public void AbrirEmpresa()
    {
        if (_sdkSesionService.IsEmpresaAbierta) return;

        _logger.LogInformation("Abriendo empresa.");
        Empresa empresa = BuscarEmpresaPruebas();
        long startTime = Stopwatch.GetTimestamp();
        _sdkSesionService.AbrirEmpresa(empresa.CRUTADATOS);
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    public void CerrarEmpresa()
    {
        if (!_sdkSesionService.IsEmpresaAbierta) return;

        _logger.LogInformation("Cerrando empresa.");
        long startTime = Stopwatch.GetTimestamp();
        _sdkSesionService.CerrarEmpresa();
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
        _logger.LogInformation("La operacion tardo {Tiempo}", elapsedTime);
    }

    private Empresa BuscarEmpresaPruebas()
    {
        return _empresaRepository.TraerTodo().FirstOrDefault(x => x.CNOMBREEMPRESA == EjemplosEmpresa.NombreEmpresaPruebas) ??
               throw new InvalidOperationException($"No se encontro la empresa con nombre: {EjemplosEmpresa.NombreEmpresaPruebas}");
    }
}