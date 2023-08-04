using System.IO;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class ArchivoDigitalHelper
{
    public static string GenerarRutaArchivoDigital(TipoArchivoDigital tipoArchivo, string rutaEmpresa, string serieDocumento,
        string folioDocumento)
    {
        string extensionArchivo = tipoArchivo == TipoArchivoDigital.Xml ? ".xml" : ".pdf";
        string nombreArchivoDigital = serieDocumento + folioDocumento + extensionArchivo;
        string rutaDirectorioArchivosDigitalesEmpresa = GenerarRutaDirectorioArchivosDigitalesEmpresa(rutaEmpresa);
        return Path.Combine(rutaDirectorioArchivosDigitalesEmpresa, nombreArchivoDigital);
    }

    public static string GenerarRutaDirectorioArchivosDigitalesEmpresa(string rutaEmpresa)
    {
        return Path.Combine(rutaEmpresa, SdkConstantes.NombreDirectorioArchivosDigitales);
    }
}
