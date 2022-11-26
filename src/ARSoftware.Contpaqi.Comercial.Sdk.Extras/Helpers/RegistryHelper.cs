﻿using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using Microsoft.Win32;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers
{
    public static class RegistryHelper
    {
        public static string GetDirectorioBaseFromRegistry(string nombreLlaveRegistro)
        {
            RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            RegistryKey keySistema = registryKey.OpenSubKey(nombreLlaveRegistro, false);

            if (keySistema is null)
                throw new ContpaqiSdkInvalidOperationException($"No se encontro la llave del registro {nombreLlaveRegistro}");

            object directorioBaseKey = keySistema.GetValue("DirectorioBase");

            if (directorioBaseKey is null)
                throw new ContpaqiSdkInvalidOperationException(
                    $"No se encontro el valor del DirectorioBase del registro {nombreLlaveRegistro}");

            return directorioBaseKey.ToString();
        }
    }
}
