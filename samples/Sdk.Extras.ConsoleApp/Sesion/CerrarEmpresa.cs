using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public sealed class CerrarEmpresa
{
    private readonly IComercialSdkSesionService _sdkSesionService;

    public CerrarEmpresa(IComercialSdkSesionService sdkSesionService)
    {
        _sdkSesionService = sdkSesionService;
    }

    public void Cerrar()
    {
        if (_sdkSesionService.CanCerrarEmpresa) _sdkSesionService.CerrarEmpresa();
    }
}
