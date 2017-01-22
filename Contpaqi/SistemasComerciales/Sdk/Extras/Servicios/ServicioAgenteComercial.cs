using Contpaqi.SistemasComerciales.Sdk.Extras.Interfaces;
using Contpaqi.SistemasComerciales.Sdk.Extras.Modelos;
using System.Collections.Generic;
using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Servicios
{
    public class ServicioAgenteComercial
    {
        private readonly ISistemasComercialesSdk _sdk;
        private readonly ServicioErrorComercial _errorComercialServicio;

        public ServicioAgenteComercial(ISistemasComercialesSdk sdk)
        {
            _sdk = sdk;
            _errorComercialServicio = new ServicioErrorComercial(sdk);
        }

        public List<AgenteComercial> TraerAgentes()
        {
            List<AgenteComercial> agentes = new List<AgenteComercial>();
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

        public AgenteComercial BuscarAgente(int idAgente)
        {
            return _sdk.fBuscaIdAgente(idAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public AgenteComercial BuscarAgente(string codigoAgente)
        {
            return _sdk.fBuscaAgente(codigoAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public AgenteComercial LeerDatosAgenteActual()
        {
            StringBuilder idAgente = new StringBuilder(12);
            StringBuilder codigoAgente = new StringBuilder(31);
            StringBuilder nombreAgente = new StringBuilder(61);
            StringBuilder tipoAgente = new StringBuilder(7);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CIDAGENTE", idAgente, 12);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CCODIGOAGENTE", codigoAgente, 31);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CNOMBREAGENTE", nombreAgente, 61);
            _errorComercialServicio.ResultadoSdk = _sdk.fLeeDatoAgente("CTIPOAGENTE", tipoAgente, 7);
            AgenteComercial agente = new AgenteComercial();
            agente.IdAgente = int.Parse(idAgente.ToString());
            agente.CodigoAgente = codigoAgente.ToString();
            agente.NombreAgente = nombreAgente.ToString();
            agente.TipoAgente = int.Parse(tipoAgente.ToString());
            return agente;
        }
    }
}
