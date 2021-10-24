using Contpaqi.Sdk.Extras.Exceptions;
using Microsoft.Win32;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public class RegistryHelper
    {
        public static string GetDirectorioBaseFromRegistry(string nombreLlaveRegistro)
        {
            var registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            var keySistema = registryKey.OpenSubKey(nombreLlaveRegistro, false);

            if (keySistema is null)
            {
                throw new ContpaqiSdkException(null, $"No se encontro la llave del registro {nombreLlaveRegistro}");
            }

            var directorioBaseKey = keySistema.GetValue("DirectorioBase");

            if (directorioBaseKey is null)
            {
                throw new ContpaqiSdkException(null, $"No se encontro el valor del DirectorioBase del registro {nombreLlaveRegistro}");
            }

            return directorioBaseKey.ToString();
        }
    }
}