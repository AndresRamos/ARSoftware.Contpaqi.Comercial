using System.IO;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ArchivoDigitalHelper
    {
        public const string NombreDirectorioArchivosDigitales = "XML_SDK";

        public static string GenerarRutaArchivoDigital(TipoArchivoDigital tipoArchivo,
                                                       string rutaEmpresa,
                                                       string serieDocumento,
                                                       string folioDocumento)
        {
            string extensionArchivo = tipoArchivo == TipoArchivoDigital.Xml ? ".xml" : ".pdf";
            string nombreArchivoDigital = serieDocumento + folioDocumento + extensionArchivo;
            string rutaDirectorioEmpresaLocal = GenerarRutaDirectorioEmpresaLocal(rutaEmpresa);
            string rutaDirectorioArchivosDigitalesEmpresa = GenerarRutaDirectorioArchivosDigitalesEmpresa(rutaDirectorioEmpresaLocal);
            return Path.Combine(rutaDirectorioArchivosDigitalesEmpresa, nombreArchivoDigital);
        }

        public static string GenerarRutaDirectorioArchivosDigitalesEmpresa(string rutaEmpresa)
        {
            return Path.Combine(rutaEmpresa, NombreDirectorioArchivosDigitales);
        }

        public static string GenerarRutaDirectorioEmpresaLocal(string rutaEmpresa)
        {
            string dirName = new DirectoryInfo(rutaEmpresa).Name;
            return Path.Combine(@"C:\Compac\Empresas", dirName);
        }
    }
}
