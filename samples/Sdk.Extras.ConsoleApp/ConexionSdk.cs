using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Extensions.Logging;

namespace Sdk.Extras.ConsoleApp;

public sealed class ConexionSdk
{
    private readonly ILogger<ConexionSdk> _logger;
    private readonly IComercialSdkSesionService _sdkSesionService;

    public ConexionSdk(ILogger<ConexionSdk> logger, IComercialSdkSesionService sdkSesionService)
    {
        _logger = logger;
        _sdkSesionService = sdkSesionService;
    }

    public void IniciarSdk()
    {
        _logger.LogInformation("Iniciando SDK");
        _sdkSesionService.IniciarSesionSdk();
        _logger.LogInformation("SDK iniciado.");
    }

    public void IniciarSdk(string usuario, string contrasena)
    {
        _logger.LogInformation("Iniciando SDK");
        _sdkSesionService.IniciarSesionSdk(usuario, contrasena);
        _logger.LogInformation("SDK iniciado.");
    }

    public void TerminarSdk()
    {
        _logger.LogInformation("Terminando SDK.");
        _sdkSesionService.TerminarSesionSdk();
        _logger.LogInformation("SDK terminado.");
    }

    public void AbrirEmpresa(Empresa empresa)
    {
        _logger.LogInformation("Abriendo empresa {Empresa}.", empresa);
        _sdkSesionService.AbrirEmpresa(empresa.CRUTADATOS);
        _logger.LogInformation("Empresa abierta.");
    }

    public void CerrarEmpresa()
    {
        _logger.LogInformation("Cerrando empresa.");
        _sdkSesionService.CerrarEmpresa();
        _logger.LogInformation("Empresa cerrada.");
    }
}
