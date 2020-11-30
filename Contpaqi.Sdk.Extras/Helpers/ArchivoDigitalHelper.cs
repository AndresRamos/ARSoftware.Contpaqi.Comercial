using System.IO;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ArchivoDigitalHelper
    {
        public const string NombreDirectorioArchivosDigitales = "XML_SDK";

        public static string GenerarRutaDirectorioEmpresaLocal(string rutaEmpresa)
        {
            var dirName = new DirectoryInfo(rutaEmpresa).Name;
            return Path.Combine(@"C:\Compac\Empresas", dirName);
        }

        public static string GenerarRutaDirectorioArchivosDigitalesEmpresa(string rutaEmpresa)
        {
            return Path.Combine(rutaEmpresa, NombreDirectorioArchivosDigitales);
        }

        public static string GenerarRutaArchivoDigital(TipoArchivoDigitalEnum tipoArchivo, string rutaEmpresa, string serieDocumento, string folioDocumento)
        {
            var extensionArchivo = tipoArchivo == TipoArchivoDigitalEnum.Xml ? ".xml" : ".pdf";
            var nombreArchivoDigital = serieDocumento + folioDocumento + extensionArchivo;
            var rutaDirectorioEmpresaLocal = GenerarRutaDirectorioEmpresaLocal(rutaEmpresa);
            var rutaDirectorioArchivosDigitalesEmpresa = GenerarRutaDirectorioArchivosDigitalesEmpresa(rutaDirectorioEmpresaLocal);
            return Path.Combine(rutaDirectorioArchivosDigitalesEmpresa, nombreArchivoDigital);
        }
    }
}