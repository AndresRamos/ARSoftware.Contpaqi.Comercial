using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IDocumentoService
    {
        void Actualizar(int documentoId, Dictionary<string, string> datosDocumento);
        void Cancelar(int idDocumento, string contrasenaCertificado);
        int Crear(tDocumento documento);
        int Crear(Dictionary<string, string> datosDocumento);
        void DesbloquearDocumento(int idDocumento);
        void Eliminar(int idDocumento);

        void GenerarDocumentoDigital(string codigoConceptoDocumento,
                                     string serieDocumento,
                                     double folioDocumento,
                                     TipoArchivoDigital tipoArchivo,
                                     string rutaPlantilla = "");

        void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, tLlaveDoc documentoRelacionado);

        void Timbrar(string codigoConceptoDocumento,
                     string serieDocumento,
                     double folioDocumento,
                     string contrasenaCertificado,
                     string rutaArchivoAdicional = "");
    }
}
