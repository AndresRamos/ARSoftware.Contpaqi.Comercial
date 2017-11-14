using System.IO;
using Microsoft.Win32;

namespace Contpaqi.Sdk.Extras.Ayudantes
{
    public static class InicializacionAdminpaqSdk
    {
        public const string NombreLlaveRegistroAdminpaq = @"SOFTWARE\\Computación en Acción, SA CV\\AdminPAQ";
        public const string NombrePaqAdminpaq = "AdminPAQ";

        public static int InicializarSDK()
        {
            var keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroAdminpaq);
            var lEntrada = keySistema.GetValue("DirectorioBase");
            Directory.SetCurrentDirectory(lEntrada.ToString());
            return AdminpaqSdk.fSetNombrePAQ(NombrePaqAdminpaq);
        }

        public static int InicializarSDK(string rutaDirectorio)
        {
            Directory.SetCurrentDirectory(rutaDirectorio);
            return AdminpaqSdk.fSetNombrePAQ(NombrePaqAdminpaq);
        }
    }
}