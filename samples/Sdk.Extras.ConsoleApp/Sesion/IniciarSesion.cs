using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public sealed class IniciarSesion
{
    private readonly IComercialSdkSesionService _sdkSesionService;

    public IniciarSesion(IComercialSdkSesionService sdkSesionService)
    {
        _sdkSesionService = sdkSesionService;
    }

    public void Iniciar()
    {
        _sdkSesionService.IniciarSesionSdk();
    }

    public void IniciarConParametros()
    {
        var usuario = "SUPERVISOR";
        var contrasena = "";

        _sdkSesionService.IniciarSesionSdk(usuario, contrasena);
    }

    public void IniciarConParametrosContabilidad()
    {
        var usuario = "SUPERVISOR";
        var contrasena = "";
        var usuarioContabilidad = "SUPERVISOR";
        var contrasenaContabilidad = "";

        _sdkSesionService.IniciarSesionSdk(usuario, contrasena, usuarioContabilidad, contrasenaContabilidad);
    }
}
