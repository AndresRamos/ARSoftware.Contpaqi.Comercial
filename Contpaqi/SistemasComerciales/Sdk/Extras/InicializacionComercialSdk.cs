using Microsoft.Win32;

namespace Contpaqi.SistemasComerciales.Sdk.Extras
{
    public static class InicializacionComercialSdk
    {
        public const string NombreLlaveRegistroComercial = @"SOFTWARE\\Computación en Acción, SA CV\\CONTPAQ I COMERCIAL";
        public const string NombrePaqComercial = "CONTPAQ I COMERCIAL";

        public static int InicializarSDK()
        {
            RegistryKey keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroComercial);
            object lEntrada = keySistema.GetValue("DirectorioBase");
            System.IO.Directory.SetCurrentDirectory(lEntrada.ToString());
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string usuario, string password)
        {
            RegistryKey keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroComercial);
            object lEntrada = keySistema.GetValue("DirectorioBase");
            System.IO.Directory.SetCurrentDirectory(lEntrada.ToString());
            ComercialSdk.fInicioSesionSDK(usuario, password);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string rutaDirectorio)
        {
            System.IO.Directory.SetCurrentDirectory(rutaDirectorio);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string rutaDirectorio, string usuario, string password)
        {
            System.IO.Directory.SetCurrentDirectory(rutaDirectorio);
            ComercialSdk.fInicioSesionSDK(usuario, password);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }
    }
}