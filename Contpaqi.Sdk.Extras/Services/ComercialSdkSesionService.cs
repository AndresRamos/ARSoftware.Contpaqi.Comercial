using Contpaqi.Sdk.Extras.Exceptions;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Repositories;

namespace Contpaqi.Sdk.Extras.Services
{
    public class ComercialSdkSesionService : IComercialSdkSesionService
    {
        private readonly IContpaqiSdk _sdk;
        private readonly SdkErrorRepository _sdkErrorRepository;

        public ComercialSdkSesionService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _sdkErrorRepository = new SdkErrorRepository(sdk);
        }

        public bool IsSdkInicializado { get; private set; }

        public bool IsEmpresaAbierta { get; private set; }

        public bool CanIniciarSesion => !IsSdkInicializado;

        public bool CanTerminarSesion => IsSdkInicializado;

        public bool CanAbrirEmpresa => IsSdkInicializado && !IsEmpresaAbierta;

        public bool CanCerrarEmpresa => IsSdkInicializado && IsEmpresaAbierta;

        public void IniciarSesionSdk()
        {
            if (!CanIniciarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede inicializar el SDK por que ya esta inicializado.");
            }

            var sdkResult = _sdk.InicializarSDK();
            if (sdkResult == SdkResultConstants.Success)
            {
                IsSdkInicializado = true;
            }
            else
            {
                var error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }

        public void IniciarSesionSdk(string nombreUsuario, string contrasena)
        {
            if (!CanIniciarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede inicializar el SDK por que ya esta inicializado.");
            }

            var sdkResult = _sdk.InicializarSDK(nombreUsuario, contrasena);
            if (sdkResult == SdkResultConstants.Success)
            {
                IsSdkInicializado = true;
            }
            else
            {
                var error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }
        
        public void IniciarSesionSdk(string nombreUsuario, string contrasena, string nombreUsuarioContabilidad, string contrasenaContabilidad)
        {
            IniciarSesionSdk(nombreUsuario, contrasena);
            _sdk.fInicioSesionSDKCONTPAQi(nombreUsuarioContabilidad, contrasenaContabilidad);
        }

        public void TerminarSesionSdk()
        {
            if (!CanTerminarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede terminar la sesion del SDK por que no ah sido inicializado.");
            }

            _sdk.fTerminaSDK();
            IsSdkInicializado = false;
        }

        public void AbrirEmpresa(string rutaEmpresa)
        {
            if (!CanAbrirEmpresa)
            {
                throw new ContpaqiSdkException(null, "No se puede abrir la empresa por que ya hay una empresa abierta.");
            }

            var sdkResult = _sdk.fAbreEmpresa(rutaEmpresa);
            if (sdkResult == SdkResultConstants.Success)
            {
                IsEmpresaAbierta = true;
            }
            else
            {
                var error = _sdkErrorRepository.BuscarMensajePorNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }

        public void CerrarEmpresa()
        {
            if (!CanCerrarEmpresa)
            {
                throw new ContpaqiSdkException(null, "No se puede cerrar la empresa por que no hay una empresa abierta.");
            }

            _sdk.fCierraEmpresa();
            IsEmpresaAbierta = false;
        }

    }
}