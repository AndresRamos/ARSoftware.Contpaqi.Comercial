using System.Collections.Generic;
using System.Globalization;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.DatosAbstractos;
using Contpaqi.Sdk.Extras.Extensions;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Services
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IContpaqiSdk _sdk;

        public DocumentoService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public void Actualizar(int documentoId, Dictionary<string, string> datosDocumento)
        {
            _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosDocumento);
            _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Cancelar(int idDocumento, string contrasenaCertificado)
        {
            _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fCancelaDoctoInfo(contrasenaCertificado).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fCancelaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public int Crear(tDocumento documento)
        {
            var documentoId = 0;
            _sdk.fAltaDocumento(ref documentoId, ref documento).ToResultadoSdk(_sdk).ThrowIfError();
            return documentoId;
        }

        public int Crear(Dictionary<string, string> datosDocumento)
        {
            _sdk.fInsertarDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatos(datosDocumento);
            _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
            string idDocumentoDato = _sdk.LeeDatoDocumento(nameof(admDocumentos.CIDDOCUMENTO), 12);
            return int.Parse(idDocumentoDato);
        }

        public void DesbloquearDocumento(int idDocumento)
        {
            _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fDesbloqueaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Eliminar(int idDocumento)
        {
            _sdk.fBuscarIdDocumento(idDocumento).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void GenerarDocumentoDigital(string codigoConceptoDocumento,
                                            string serieDocumento,
                                            double folioDocumento,
                                            TipoArchivoDigital tipoArchivo,
                                            string rutaPlantilla)
        {
            _sdk.fEntregEnDiscoXML(codigoConceptoDocumento, serieDocumento, folioDocumento, (int)tipoArchivo, rutaPlantilla)
                .ToResultadoSdk(_sdk)
                .ThrowIfError();
        }

        public void RelacionarDocumentos(tLlaveDoc documento, string tipoRelacion, tLlaveDoc documentoRelacionado)
        {
            _sdk.fAgregarRelacionCFDI(documento.aCodConcepto,
                    documento.aSerie,
                    documento.aFolio.ToString(CultureInfo.InvariantCulture),
                    tipoRelacion,
                    documentoRelacionado.aCodConcepto,
                    documentoRelacionado.aSerie,
                    documentoRelacionado.aFolio.ToString(CultureInfo.InvariantCulture))
                .ToResultadoSdk(_sdk)
                .ThrowIfError();
        }

        public void Timbrar(string codigoConceptoDocumento,
                            string serieDocumento,
                            double folioDocumento,
                            string contrasenaCertificado,
                            string rutaArchivoAdicional)
        {
            _sdk.fEmitirDocumento(codigoConceptoDocumento, serieDocumento, folioDocumento, contrasenaCertificado, rutaArchivoAdicional)
                .ToResultadoSdk(_sdk)
                .ThrowIfError();
        }

        public void SetDatos(Dictionary<string, string> datos)
        {
            foreach (KeyValuePair<string, string> dato in datos)
            {
                _sdk.fSetDatoDocumento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }
        }
    }
}
