using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

namespace Sdk.Extras.ConsoleApp;

public sealed class AbrirEmpresa
{
    private readonly IComercialSdkSesionService _sdkSesionService;

    public AbrirEmpresa(IComercialSdkSesionService sdkSesionService)
    {
        _sdkSesionService = sdkSesionService;
    }

    public void Abrir()
    {
        var rutaEmpresa = @"C:\Compac\Empresas\adUNIVERSIDAD_ROBOTICA";

        _sdkSesionService.AbrirEmpresa(rutaEmpresa);
    }
}
