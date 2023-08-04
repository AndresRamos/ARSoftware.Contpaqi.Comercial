using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public sealed class TerminasSesion
{
    private readonly IComercialSdkSesionService _sdkSesionService;

    public TerminasSesion(IComercialSdkSesionService sdkSesionService)
    {
        _sdkSesionService = sdkSesionService;
    }

    public void Terminar()
    {
        if (_sdkSesionService.CanTerminarSesion) _sdkSesionService.TerminarSesionSdk();
    }
}
