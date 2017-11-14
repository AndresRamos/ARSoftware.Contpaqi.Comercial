using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class ConceptoDocumentoRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public ConceptoDocumentoRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public ConceptoDocumento BuscarConceptoDocumento(int idConcepto)
        {
            return _sdk.fBuscaIdConceptoDocto(idConcepto) == 0 ? LeerDatosConceptoDocumentoActual() : null;
        }

        public ConceptoDocumento BuscarConceptoDocumento(string codigoConcepto)
        {
            return _sdk.fBuscaConceptoDocto(codigoConcepto) == 0 ? LeerDatosConceptoDocumentoActual() : null;
        }

        public IEnumerable<ConceptoDocumento> TraerConceptosDocumento()
        {
            var conceptosList = new List<ConceptoDocumento>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerConceptoDocto();
            conceptosList.Add(LeerDatosConceptoDocumentoActual());
            while (_sdk.fPosSiguienteConceptoDocto() == 0)
            {
                conceptosList.Add(LeerDatosConceptoDocumentoActual());
                if (_sdk.fPosEOFConceptoDocto() == 1)
                {
                    break;
                }
            }
            return conceptosList;
        }

        private ConceptoDocumento LeerDatosConceptoDocumentoActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(Constantes.kLongCodigo);
            var nombre = new StringBuilder(Constantes.kLongNombre);
            var esCfd = new StringBuilder(6);
            var versionEsquemaSat = new StringBuilder(7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CIDCONCEPTODOCUMENTO", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CCODIGOCONCEPTO", codigo, Constantes.kLongCodigo);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CNOMBRECONCEPTO", nombre, Constantes.kLongNombre);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CESCFD", esCfd, 6);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CVERESQUE", versionEsquemaSat, 7);
            var conceptoDeDocumento = new ConceptoDocumento
            {
                Id = int.Parse(id.ToString()),
                Codigo = codigo.ToString(),
                Nombre = nombre.ToString(),
                EsCfd = esCfd.ToString() != "0",
                VersionEsquemaSat = versionEsquemaSat.ToString()
            };
            return conceptoDeDocumento;
        }
    }
}