namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IComercialSdkSesionService
    {
        bool CanAbrirEmpresa { get; }
        bool CanCerrarEmpresa { get; }
        bool CanIniciarSesion { get; }
        bool CanTerminarSesion { get; }
        bool IsEmpresaAbierta { get; }
        bool IsSdkInicializado { get; }
        void AbrirEmpresa(string rutaEmpresa);
        void CerrarEmpresa();
        void IniciarSesionSdk();
        void IniciarSesionSdk(string nombreUsuario, string contrasena);
        void IniciarSesionSdk(string nombreUsuario, string contrasena, string nombreUsuarioContabilidad, string contrasenaContabilidad);
        void TerminarSesionSdk();
    }
}
