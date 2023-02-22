using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IDocumentoService
    {
        void Actualizar(int documentoId, Dictionary<string, string> datosDocumento);
        void Actualizar(string codigoConcepto, string serie, string folio, Dictionary<string, string> datosDocumento);
        void Actualizar(tLlaveDoc tLlaveDocumento, Dictionary<string, string> datosDocumento);
        tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto);
        void Cancelar(int idDocumento, string contrasenaCertificado);
        void Cancelar(int idDocumento, string contrasenaCertificado, string motivoCancelacion, string uuidRemplazo);
        void CancelarAdministrativamente(int idDocumento);
        void CancelarAdministrativamente(string codigoConcepto, string serie, string folio);
        void CancelarAdministrativamente(tLlaveDoc tLlaveDocumento);
        int Crear(tDocumento documento);
        int Crear(Dictionary<string, string> datosDocumento);
        int CrearCargoAbono(tDocumento documento);
        void DesbloquearDocumento(int idDocumento);
        void Eliminar(int idDocumento);
        void Eliminar(string codigoConcepto, string serie, string folio);
        void Eliminar(tLlaveDoc tLlaveDocumento);

        void GenerarDocumentoDigital(string codigoConceptoDocumento,
                                     string serieDocumento,
                                     double folioDocumento,
                                     TipoArchivoDigital tipoArchivo,
                                     string rutaPlantilla = "");

        void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, tLlaveDoc documentoRelacionado);
        void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, string uuid);

        void SaldarDocumento(tLlaveDoc documentoAPagar, tLlaveDoc documentoPago, DateTime fecha, double importe, int monedaId = 1);

        void Timbrar(string codigoConceptoDocumento,
                     string serieDocumento,
                     double folioDocumento,
                     string contrasenaCertificado,
                     string rutaArchivoAdicional = "");

        void Timbrar(tLlaveDoc documento, string contrasenaCertificado, string rutaArchivoAdicional = "");
    }
}
