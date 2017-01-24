using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioConceptoDocumentoComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioConceptoDocumentoComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public ConceptoDocumentoComercial BuscarConceptoDocumento(int idConcepto)
        {
            return _sdk.fBuscaIdConceptoDocto(idConcepto) == 9 ? LeerDatosConceptoDocumentoActual() : null;
        }

        public ConceptoDocumentoComercial BuscarConceptoDocumento(string codigoConcepto)
        {
            return _sdk.fBuscaConceptoDocto(codigoConcepto) == 0 ? LeerDatosConceptoDocumentoActual() : null;
        }

        public IEnumerable<ConceptoDocumentoComercial> TraerConceptosDocumento()
        {
            List<ConceptoDocumentoComercial> conceptosList = new List<ConceptoDocumentoComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerConceptoDocto();
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

        private ConceptoDocumentoComercial LeerDatosConceptoDocumentoActual()
        {
            StringBuilder id = new StringBuilder(12);
            StringBuilder codigo = new StringBuilder(Constantes.kLongCodigo);
            StringBuilder nombre = new StringBuilder(Constantes.kLongNombre);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CIDCONCEPTODOCUMENTO", id, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CCODIGOCONCEPTO", codigo, Constantes.kLongCodigo);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoConceptoDocto("CNOMBRECONCEPTO", nombre, Constantes.kLongNombre);
            ConceptoDocumentoComercial conceptoDeDocumento = new ConceptoDocumentoComercial();
            conceptoDeDocumento.IdConcepto = int.Parse(id.ToString());
            conceptoDeDocumento.CodigoConcepto = codigo.ToString();
            conceptoDeDocumento.NombreConcepto = nombre.ToString();
            return conceptoDeDocumento;
        }
    }
}