using Contpaqi.Sdk.Extras.Excepciones;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using Contpaqi.Sdk.Extras.Repositorios;

namespace Contpaqi.Sdk.Extras.Servicios
{
    public class ComercialSdkSesionServicio : IComercialSdkSesionServicio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public ComercialSdkSesionServicio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
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
            if (sdkResult == SdkResult.Exito)
            {
                SdkInicializado = true;
            }
            else
            {
                var error = _errorContpaqiSdkRepositorio.LeerError(sdkResult);
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
            if (sdkResult == SdkResult.Exito)
            {
                SdkInicializado = true;
            }
            else
            {
                var error = _errorContpaqiSdkRepositorio.LeerError(sdkResult);
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
            if (sdkResult == SdkResult.Exito)
            {
                EmpresaAbierta = true;
            }
            else
            {
                var error = _errorContpaqiSdkRepositorio.LeerError(sdkResult);
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