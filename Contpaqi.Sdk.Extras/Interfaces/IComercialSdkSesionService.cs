namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IComercialSdkSesionService
    {
        bool IsSdkInicializado { get; }
        bool IsEmpresaAbierta { get; }
        bool CanIniciarSesion { get; }
        bool CanTerminarSesion { get; }
        bool CanAbrirEmpresa { get; }
        bool CanCerrarEmpresa { get; }
        void IniciarSesionSdk();
        void IniciarSesionSdk(string nombreUsuario, string contrasena);
        void IniciarSesionSdk(string nombreUsuario, string contrasena, string nombreUsuarioContabilidad, string contrasenaContabilidad);
        void TerminarSesionSdk();
        void AbrirEmpresa(string rutaEmpresa);
        void CerrarEmpresa();
    }
}