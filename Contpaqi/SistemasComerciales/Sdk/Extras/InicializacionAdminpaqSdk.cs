using Microsoft.Win32;

namespace Contpaqi.SistemasComerciales.Sdk.Extras
{
    public static class InicializacionAdminpaqSdk
    {
        public const string NombreLlaveRegistroAdminpaq = @"SOFTWARE\\Computación en Acción, SA CV\\AdminPAQ";
        public const string NombrePaqAdminpaq = "AdminPAQ";

        public static int InicializarSDK()
        {
            RegistryKey keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroAdminpaq);
            object lEntrada = keySistema.GetValue("DirectorioBase");
            System.IO.Directory.SetCurrentDirectory(lEntrada.ToString());
            return ComercialSdk.fSetNombrePAQ(NombrePaqAdminpaq);
        }

        public static int InicializarSDK(string rutaDirectorio)
        {
            System.IO.Directory.SetCurrentDirectory(rutaDirectorio);
            return ComercialSdk.fSetNombrePAQ(NombrePaqAdminpaq);
        }
    }
}