using ARSoftware.Contpaqi.Comercial.Sdk;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;
using Microsoft.Win32;

namespace ARSoftware.Contpaqi.Comercial.ConsoleApp;

/// <summary>
///     Inicia y termina conexiones con el sistema
/// </summary>
public sealed class ConexionSdk
{
    /// <summary>
    ///     Inicia la conexión con el sistema y muestra una ventana de autenticación donde el usuario podrá ingresar su nombre
    ///     de usuario y contraseña.
    /// </summary>
    public static void IniciarSdk()
    {
        // Establecer el directorio de trabajo en el directorio donde se encuentra el SDK
        EstablecerElDirectorioDeTrabajo();

        // Iniciar conexion
        ComercialSdk.fSetNombrePAQ(NombresPaqSdk.Comercial).TirarSiEsError();
    }

    /// <summary>
    ///     Inicia la conexion con el sistema e ingresa el usuario y contrasena programaticamente para que no se muestre la
    ///     ventana de autenticacion de Comercial
    /// </summary>
    /// <param name="nombreUsuario">Nombre de usuario del sistema de Comercial</param>
    /// <param name="contrasena">Contrasena del sistema de Comercial</param>
    public static void IniciarSdk(string nombreUsuario, string contrasena)
    {
        // Establecer el directorio de trabajo en el directorio donde se encuentra el SDK
        EstablecerElDirectorioDeTrabajo();

        // Ingresar programaticamente el usuario y contrasena del sistema de Comercial
        ComercialSdk.fInicioSesionSDK(nombreUsuario, contrasena);

        // Iniciar conexion
        ComercialSdk.fSetNombrePAQ(NombresPaqSdk.Comercial).TirarSiEsError();
    }

    /// <summary>
    ///     Inicia la conexion con el sistema e ingresa el usuario y contrasena programaticamente para que no se muestre la
    ///     ventana de autenticacion de Comercial o Contabilidad
    /// </summary>
    /// <param name="nombreusuariocomercial">Nombre de usuario del sistema de Comercial</param>
    /// <param name="contrasenacomercial">Contrasena del sistema de Comercial</param>
    /// <param name="nombreusuariocontabilidad">Nombre de usuario del sistema de Contabilidad</param>
    /// <param name="contrasenacontabilidad">Contrasena del sistema de Contabilidad</param>
    public static void IniciarSdk(string nombreusuariocomercial, string contrasenacomercial, string nombreusuariocontabilidad,
                                  string contrasenacontabilidad)
    {
        // Iniciar conexion con el sistema
        IniciarSdk(nombreusuariocomercial, contrasenacomercial);

        // Ingresar programaticamente el usuario y contrasena del sistema de Contabilidad
        ComercialSdk.fInicioSesionSDKCONTPAQi(nombreusuariocontabilidad, contrasenacontabilidad);
    }

    /// <summary>
    ///     Termina la conexion con el sistema y libera recursos
    /// </summary>
    public static void TerminarSdk()
    {
        ComercialSdk.fTerminaSDK();
    }

    /// <summary>
    ///     Abre la empresa de trabajo
    /// </summary>
    /// <param name="rutaEmpresa">Ruta del directorio de la empresa.</param>
    public static void AbrirEmpresa(string rutaEmpresa)
    {
        ComercialSdk.fAbreEmpresa(rutaEmpresa).TirarSiEsError();
    }

    /// <summary>
    ///     Cierra la empresa de trabajo.
    /// </summary>
    public static void CerrarEmpresa()
    {
        ComercialSdk.fCierraEmpresa();
    }

    /// <summary>
    ///     Establece el directorio de trabajo en el directorio donde se encuentra el SDK
    /// </summary>
    private static void EstablecerElDirectorioDeTrabajo()
    {
        // Buscar directorio donde se encuentra el SDK
        string rutaSdk = BuscarDirectorioDelSdk(LlavesRegistroWindowsSdk.Comercial);

        // Establecer el directorio de trabajo en el directorio donde se encuentra el SDK
        Directory.SetCurrentDirectory(rutaSdk);
    }

    /// <summary>
    ///     Busca el directorio donde se encuentra el SDK en el registro de Windows.
    /// </summary>
    /// <param name="nombreLlaveRegistro">La llave del registro de Windows.</param>
    /// <returns>La ruta del directorio donde se encuentra el SDK.</returns>
    private static string BuscarDirectorioDelSdk(string nombreLlaveRegistro)
    {
        // Buscar registro de windows
        RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

        // Buscar la llave de CONTPAQi
        RegistryKey keySitema = registryKey.OpenSubKey(nombreLlaveRegistro, false);

        if (keySitema is null)
        {
            // No se encontro la llave
            throw new ContpaqiSdkExcepcion(null, $"No se encontro la llave del registro {nombreLlaveRegistro}");
        }

        // Leer el valor del campo DIRECTORIOBASE donde se encuentra la ruta del SDK
        object directorioBaseKey = keySitema.GetValue(LlavesRegistroWindowsSdk.NombreCampoRutaSdk);

        if (directorioBaseKey is null)
            throw new ContpaqiSdkExcepcion(null,
                $"No se encontro el valor del campo {LlavesRegistroWindowsSdk.NombreCampoRutaSdk} del registro {nombreLlaveRegistro}");

        return directorioBaseKey.ToString();
    }
}
