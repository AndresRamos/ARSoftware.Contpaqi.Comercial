using System.Collections.Generic;
using System.Text;
using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioAgenteComercial
    {
        private readonly ServicioErrorComercial _errorComercialServicio;
        private readonly ISistemasComercialesSdk _sdk;

        public ServicioAgenteComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public AgenteComercial BuscarAgente(int idAgente)
        {
            return _sdk.fBuscaIdAgente(idAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public AgenteComercial BuscarAgente(string codigoAgente)
        {
            return _sdk.fBuscaAgente(codigoAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public List<AgenteComercial> TraerAgentes()
        {
            var agentes = new List<AgenteComercial>();
            _errorComercialServicio.ResultadoSdk = _sdk.fPosPrimerAgente();
            agentes.Add(LeerDatosAgenteActual());
            while (_sdk.fPosSiguienteAgente() == 0)
            {
                agentes.Add(LeerDatosAgenteActual());
                if (_sdk.fPosEOFAgente() == 1)
                {
                    break;
                }
            }
            return agentes;
        }

        private AgenteComercial LeerDatosAgenteActual()
        {
            var idAgente = new StringBuilder(12);
            var codigoAgente = new StringBuilder(31);
            var nombreAgente = new StringBuilder(61);
            var tipoAgente = new StringBuilder(7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CIDAGENTE", idAgente, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CCODIGOAGENTE", codigoAgente, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CNOMBREAGENTE", nombreAgente, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CTIPOAGENTE", tipoAgente, 7);
            var agente = new AgenteComercial();
            agente.IdAgente = int.Parse(idAgente.ToString());
            agente.CodigoAgente = codigoAgente.ToString();
            agente.NombreAgente = nombreAgente.ToString();
            agente.TipoAgente = int.Parse(tipoAgente.ToString());
            return agente;
        }
    }
}