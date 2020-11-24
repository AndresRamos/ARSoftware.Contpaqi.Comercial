using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Repositorios
{
    public class AgenteRepositorio : IAgenteRepositorio
    {
        private readonly ErrorContpaqiSdkRepositorio _errorContpaqiSdkRepositorio;
        private readonly IContpaqiSdk _sdk;

        public AgenteRepositorio(IContpaqiSdk sdk)
        {
            _sdk = sdk;
            _errorContpaqiSdkRepositorio = new ErrorContpaqiSdkRepositorio(sdk);
        }

        public Agente BuscarAgente(int idAgente)
        {
            return _sdk.fBuscaIdAgente(idAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public Agente BuscarAgente(string codigoAgente)
        {
            return _sdk.fBuscaAgente(codigoAgente) == 0 ? LeerDatosAgenteActual() : null;
        }

        public IEnumerable<Agente> TraerAgentes()
        {
            var agentes = new List<Agente>();
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fPosPrimerAgente();
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

        private Agente LeerDatosAgenteActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(31);
            var nombre = new StringBuilder(61);
            var tipo = new StringBuilder(7);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAgente("CIDAGENTE", id, 12);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAgente("CCODIGOAGENTE", codigo, 31);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAgente("CNOMBREAGENTE", nombre, 61);
            _errorContpaqiSdkRepositorio.ResultadoSdk = _sdk.fLeeDatoAgente("CTIPOAGENTE", tipo, 7);
            var agente = new Agente
            {
                Id = int.Parse(id.ToString()),
                Codigo = codigo.ToString(),
                Nombre = nombre.ToString(),
                Tipo = int.Parse(tipo.ToString())
            };
            return agente;
        }
    }
}