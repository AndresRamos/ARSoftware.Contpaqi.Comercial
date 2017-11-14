using System.IO;
using Microsoft.Win32;

namespace Contpaqi.Sdk.Extras.Ayudantes
{
    public static class InicializacionComercialSdk
    {
        public const string NombreLlaveRegistroComercial = @"SOFTWARE\\Computación en Acción, SA CV\\CONTPAQ I COMERCIAL";
        public const string NombrePaqComercial = "CONTPAQ I COMERCIAL";

        public static int InicializarSDK()
        {
            var keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroComercial);
            var lEntrada = keySistema.GetValue("DirectorioBase");
            Directory.SetCurrentDirectory(lEntrada.ToString());
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string usuario, string password)
        {
            var keySistema = Registry.LocalMachine.OpenSubKey(NombreLlaveRegistroComercial);
            var lEntrada = keySistema.GetValue("DirectorioBase");
            Directory.SetCurrentDirectory(lEntrada.ToString());
            ComercialSdk.fInicioSesionSDK(usuario, password);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string rutaDirectorio)
        {
            Directory.SetCurrentDirectory(rutaDirectorio);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }

        public static int InicializarSDK(string rutaDirectorio, string usuario, string password)
        {
            Directory.SetCurrentDirectory(rutaDirectorio);
            ComercialSdk.fInicioSesionSDK(usuario, password);
            return ComercialSdk.fSetNombrePAQ(NombrePaqComercial);
        }
    }
}