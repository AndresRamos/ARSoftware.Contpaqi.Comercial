using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class ConceptoDocumentoRepository : IConceptoDocumentoRepository<ConceptoDocumento>
    {
        private readonly IContpaqiSdk _sdk;

        public ConceptoDocumentoRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public ConceptoDocumento BuscarPorId(int idConcepto)
        {
            return _sdk.fBuscaIdConceptoDocto(idConcepto) == SdkResultConstants.Success ? LeerDatosConceptoDocumentoActual() : null;
        }

        public ConceptoDocumento BuscarPorCodigo(string codigoConcepto)
        {
            return _sdk.fBuscaConceptoDocto(codigoConcepto) == SdkResultConstants.Success ? LeerDatosConceptoDocumentoActual() : null;
        }

        public IEnumerable<ConceptoDocumento> TraerTodo()
        {
            _sdk.fPosPrimerConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosConceptoDocumentoActual();

            while (_sdk.fPosSiguienteConceptoDocto() == SdkResultConstants.Success)
            {
                yield return LeerDatosConceptoDocumentoActual();
                if (_sdk.fPosEOFConceptoDocto() == 1)
                {
                    break;
                }
            }
        }

        public IEnumerable<ConceptoDocumento> TraerPorDocumentoModeloId(int documentoModeloId)
        {
            var idDocumentoModelo = new StringBuilder(12);

            _sdk.fPosPrimerConceptoDocto().ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CIDDOCUMENTODE", idDocumentoModelo, 12).ToResultadoSdk(_sdk).ThrowIfError();
            if (documentoModeloId == int.Parse(idDocumentoModelo.ToString()))
            {
                yield return LeerDatosConceptoDocumentoActual();
            }

            while (_sdk.fPosSiguienteConceptoDocto() == SdkResultConstants.Success)
            {
                _sdk.fLeeDatoConceptoDocto("CIDDOCUMENTODE", idDocumentoModelo, 12).ToResultadoSdk(_sdk).ThrowIfError();
                if (documentoModeloId == int.Parse(idDocumentoModelo.ToString()))
                {
                    yield return LeerDatosConceptoDocumentoActual();
                }

                if (_sdk.fPosEOFConceptoDocto() == 1)
                {
                    break;
                }
            }
        }

        private ConceptoDocumento LeerDatosConceptoDocumentoActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(Constantes.kLongCodigo);
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var esCfd = new StringBuilder(6);
            var versionEsquemaSat = new StringBuilder(7);
            var idDocumentoModelo = new StringBuilder(12);

            _sdk.fLeeDatoConceptoDocto("CIDCONCEPTODOCUMENTO", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CCODIGOCONCEPTO", codigo, Constantes.kLongCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CNOMBRECONCEPTO", nombre, Constantes.kLongNombre).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CIDDOCUMENTODE", idDocumentoModelo, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CESCFD", esCfd, 6).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoConceptoDocto("CVERESQUE", versionEsquemaSat, 7).ToResultadoSdk(_sdk).ThrowIfError();

            var conceptoDeDocumento = new ConceptoDocumento();
            conceptoDeDocumento.Id = int.Parse(id.ToString());
            conceptoDeDocumento.Codigo = codigo.ToString();
            conceptoDeDocumento.Nombre = nombre.ToString();
            conceptoDeDocumento.IdDocumentoModelo = int.Parse(idDocumentoModelo.ToString());
            conceptoDeDocumento.EsCfd = esCfd.ToString() != "0";
            conceptoDeDocumento.VersionEsquemaSat = versionEsquemaSat.ToString();

            return conceptoDeDocumento;
        }
    }
}