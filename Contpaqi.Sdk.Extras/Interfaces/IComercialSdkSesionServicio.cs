namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IComercialSdkSesionServicio
    {
        bool SdkInicializado { get; }
        bool EmpresaAbierta { get; }
        bool PuedeIniciarSesion { get; }
        bool PuedeTerminarSesion { get; }
        bool PuedeAbrirEmpresa { get; }
        bool PuedeCerrarEmpresa { get; }
        void IniciarSesionSdk();
        void IniciarSesionSdk(string nombreUsuario, string contrasena);
        void TerminarSesionSdk();
        void AbrirEmpresa(string rutaEmpresa);
        void CerrarEmpresa();
      
    }
}