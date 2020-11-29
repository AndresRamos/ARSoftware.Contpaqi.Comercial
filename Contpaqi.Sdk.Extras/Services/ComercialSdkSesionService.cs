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

        public bool SdkInicializado { get; private set; }

        public bool EmpresaAbierta { get; private set; }

        public bool PuedeIniciarSesion => !SdkInicializado;

        public bool PuedeTerminarSesion => SdkInicializado;

        public bool PuedeAbrirEmpresa => SdkInicializado && !EmpresaAbierta;

        public bool PuedeCerrarEmpresa => SdkInicializado && EmpresaAbierta;

        public void IniciarSesionSdk()
        {
            if (!PuedeIniciarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede inicializar el SDK por que ya esta inicializado.");
            }

            var sdkResult = _sdk.InicializarSDK();
            if (sdkResult == SdkResultConstants.Success)
            {
                SdkInicializado = true;
            }
            else
            {
                var error = _sdkErrorRepository.FindMensajeByNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }

        public void IniciarSesionSdk(string nombreUsuario, string contrasena)
        {
            if (!PuedeIniciarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede inicializar el SDK por que ya esta inicializado.");
            }

            var sdkResult = _sdk.InicializarSDK(nombreUsuario, contrasena);
            if (sdkResult == SdkResultConstants.Success)
            {
                SdkInicializado = true;
            }
            else
            {
                var error = _sdkErrorRepository.FindMensajeByNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }

        public void TerminarSesionSdk()
        {
            if (!PuedeTerminarSesion)
            {
                throw new ContpaqiSdkException(null, "No se puede terminar la sesion del SDK por que no ah sido inicializado.");
            }

            _sdk.fTerminaSDK();

            SdkInicializado = false;
        }

        public void AbrirEmpresa(string rutaEmpresa)
        {
            if (!PuedeAbrirEmpresa)
            {
                throw new ContpaqiSdkException(null, "No se puede abrir la empresa por que ya hay una empresa abierta.");
            }

            var sdkResult = _sdk.fAbreEmpresa(rutaEmpresa);
            if (sdkResult == SdkResultConstants.Success)
            {
                EmpresaAbierta = true;
            }
            else
            {
                var error = _sdkErrorRepository.FindMensajeByNumero(sdkResult);
                throw new ContpaqiSdkException(sdkResult, error);
            }
        }

        public void CerrarEmpresa()
        {
            if (!PuedeCerrarEmpresa)
            {
                throw new ContpaqiSdkException(null, "No se puede cerrar la empresa por que no hay una empresa abierta.");
            }

            _sdk.fCierraEmpresa();

            EmpresaAbierta = false;
        }
    }
}