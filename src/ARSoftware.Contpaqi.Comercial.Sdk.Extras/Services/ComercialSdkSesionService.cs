using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Services;

public class ComercialSdkSesionService : IComercialSdkSesionService
{
    private readonly IContpaqiSdk _sdk;
    private readonly SdkErrorRepository _sdkErrorRepository;

    public ComercialSdkSesionService(IContpaqiSdk sdk)
    {
        _sdk = sdk;
        _sdkErrorRepository = new SdkErrorRepository(sdk);
    }

    public void AbrirEmpresa(string rutaEmpresa)
    {
        if (!CanAbrirEmpresa)
            throw new ContpaqiSdkInvalidOperationException("No se puede abrir la empresa por que ya hay una empresa abierta.");

        int sdkResult = _sdk.fAbreEmpresa(rutaEmpresa);
        if (sdkResult == SdkResultConstants.Success)
            IsEmpresaAbierta = true;
        else
        {
            string error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
            throw new ContpaqiSdkException(sdkResult, error);
        }
    }

    public bool CanAbrirEmpresa => IsSdkInicializado && !IsEmpresaAbierta;

    public bool CanCerrarEmpresa => IsSdkInicializado && IsEmpresaAbierta;

    public bool CanIniciarSesion => !IsSdkInicializado;

    public bool CanTerminarSesion => IsSdkInicializado;

    public void CerrarEmpresa()
    {
        if (!CanCerrarEmpresa)
            throw new ContpaqiSdkInvalidOperationException("No se puede cerrar la empresa por que no hay una empresa abierta.");

        _sdk.fCierraEmpresa();
        IsEmpresaAbierta = false;
    }

    public void IniciarSesionSdk()
    {
        if (!CanIniciarSesion)
            throw new ContpaqiSdkInvalidOperationException("No se puede inicializar el SDK por que ya esta inicializado.");

        int sdkResult = _sdk.InicializarSDK();
        if (sdkResult == SdkResultConstants.Success)
            IsSdkInicializado = true;
        else
        {
            string error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
            throw new ContpaqiSdkException(sdkResult, error);
        }
    }

    public void IniciarSesionSdk(string nombreUsuario, string contrasena)
    {
        if (!CanIniciarSesion)
            throw new ContpaqiSdkInvalidOperationException("No se puede inicializar el SDK por que ya esta inicializado.");

        int sdkResult = _sdk.InicializarSDK(nombreUsuario, contrasena);
        if (sdkResult == SdkResultConstants.Success)
            IsSdkInicializado = true;
        else
        {
            string error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
            throw new ContpaqiSdkException(sdkResult, error);
        }
    }

    public void IniciarSesionSdk(string nombreUsuario, string contrasena, string nombreUsuarioContabilidad, string contrasenaContabilidad)
    {
        IniciarSesionSdk(nombreUsuario, contrasena);
        _sdk.fInicioSesionSDKCONTPAQi(nombreUsuarioContabilidad, contrasenaContabilidad);
    }

    /// <inheritdoc />
    public bool IsComercialSdk()
    {
        return _sdk is ComercialSdkExtended;
    }

    public bool IsEmpresaAbierta { get; private set; }

    /// <inheritdoc />
    public bool IsFacturaElectronicaSdk()
    {
        return _sdk is FacturaElectronicaSdkExtended;
    }

    public bool IsSdkInicializado { get; private set; }

    public void TerminarSesionSdk()
    {
        if (!CanTerminarSesion)
            throw new ContpaqiSdkInvalidOperationException("No se puede terminar la sesion del SDK por que no ah sido inicializado.");

        _sdk.fTerminaSDK();
        IsSdkInicializado = false;
    }
}
