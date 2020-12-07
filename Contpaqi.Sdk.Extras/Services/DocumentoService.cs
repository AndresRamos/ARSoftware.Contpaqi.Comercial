using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Helpers;
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

        public int Crear(tDocumento documento)
        {
            var documentoId = 0;

            _sdk.fAltaDocumento(ref documentoId, ref documento).ToResultadoSdk(_sdk).ThrowIfError();

            return documentoId;
        }

        public void Actualizar(int documentoId, Dictionary<string, string> datosDocumento)
        {
            _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditarDocumento().ToResultadoSdk(_sdk).ThrowIfError();

            foreach (var dato in datosDocumento)
            {
                _sdk.fSetDatoDocumento(dato.Key, dato.Value).ToResultadoSdk(_sdk).ThrowIfError();
            }

            _sdk.fGuardaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Eliminar(int documentoId)
        {
            _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fBorraDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Cancelar(int documentoId, string contrasenaCertificado)
        {
            _sdk.fBuscarIdDocumento(documentoId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fCancelaDoctoInfo(contrasenaCertificado).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fCancelaDocumento().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Timbrar(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, string contrasenaCertificado)
        {
            _sdk.fEmitirDocumento(codigoConceptoDocumento, serieDocumento, folioDocumento, contrasenaCertificado, "").ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void GenerarDocumentoDigital(string codigoConceptoDocumento, string serieDocumento, double folioDocumento, TipoArchivoDigitalEnum tipoArchivo, string rutaPlantilla)
        {
            _sdk.fEntregEnDiscoXML(codigoConceptoDocumento, serieDocumento, folioDocumento, (int) tipoArchivo, rutaPlantilla).ToResultadoSdk(_sdk).ThrowIfError();
        }
    }
}