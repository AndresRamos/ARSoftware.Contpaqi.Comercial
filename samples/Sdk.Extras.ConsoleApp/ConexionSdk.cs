using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp;

public sealed class ConexionSdk
{
    private readonly ILogger<ConexionSdk> _logger;
    private readonly IComercialSdkSesionService _sdkSesionService;

    public ConexionSdk(IComercialSdkSesionService sdkSesionService, ILogger<ConexionSdk> logger)
    {
        _sdkSesionService = sdkSesionService;
        _logger = logger;
    }

    public void IniciarConexion()
    {
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
        _logger.LogInformation("IniciarSesionSdk()");
        _sdkSesionService.IniciarSesionSdk();
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
    }

    public void IniciarConexionConParametros(string usuario, string contrasena)
    {
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
        _logger.LogInformation("IniciarSesionSdk(usuario, contrasena)");
        _sdkSesionService.IniciarSesionSdk(usuario, contrasena);
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
    }

    public void TerminarConexion()
    {
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
        _logger.LogInformation("TerminarSesionSdk()");
        if (_sdkSesionService.IsSdkInicializado)
            _sdkSesionService.TerminarSesionSdk();
        _logger.LogInformation("Is SDK Inicializado: {IsSdkInicializado}", _sdkSesionService.IsSdkInicializado);
    }

    public void AbrirEmpresa(Empresa empresa)
    {
        _logger.LogInformation("Is Empresa Abierta: {IsEmpresaAbierta}", _sdkSesionService.IsEmpresaAbierta);
        _logger.LogInformation("AbrirEmpresa(rutaEmpresa)");
        _sdkSesionService.AbrirEmpresa(empresa.CRUTADATOS);
        _logger.LogInformation("Is Empresa Abierta: {IsEmpresaAbierta}", _sdkSesionService.IsEmpresaAbierta);
    }

    public void CerrarEmpresa()
    {
        _logger.LogInformation("Is Empresa Abierta: {IsEmpresaAbierta}", _sdkSesionService.IsEmpresaAbierta);
        _logger.LogInformation("CerrarEmpresa()");
        if (_sdkSesionService.IsEmpresaAbierta)
            _logger.LogInformation("Is Empresa Abierta: {IsEmpresaAbierta}", _sdkSesionService.IsEmpresaAbierta);
        _logger.LogInformation("Is Empresa Abierta: {IsEmpresaAbierta}", _sdkSesionService.IsEmpresaAbierta);
    }
}
