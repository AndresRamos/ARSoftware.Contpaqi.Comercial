using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDocumentoService
    {
        int Crear(tDocumento documento);
        void Actualizar(int documentoId, Dictionary<string, string> datosDocuemnto);
        void Eliminar(int documentoId); 
        void Cancelar(int documentoId, string contrasenaCertificado);
        void Timbrar(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, string contrasenaCertificado);
        void GenerarDocumentoDigital(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, TipoArchivoDigitalEnum tipoArchivo, string rutaPlantilla);
    }
}