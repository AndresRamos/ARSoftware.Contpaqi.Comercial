using System.Collections.Generic;
using Contpaqi.Sdk.DatosAbstractos;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
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
