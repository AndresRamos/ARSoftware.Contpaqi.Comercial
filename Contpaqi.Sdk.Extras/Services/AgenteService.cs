using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Services
{
    public class AgenteService : IAgenteService
    {
        private readonly IContpaqiSdk _sdk;

        public AgenteService(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public int Crear(Dictionary<string, string> datosAgente)
        {
            _sdk.fInsertaAgente().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAgente(datosAgente);
            _sdk.fGuardaAgente().ToResultadoSdk(_sdk).ThrowIfError();

            var idAgenteDato = new StringBuilder(12);
            _sdk.fLeeDatoAgente("CIDAGENTE", idAgenteDato, 12).ToResultadoSdk(_sdk).ThrowIfError();
            return int.Parse(idAgenteDato.ToString());
        }

        public void Actualizar(int agenteId, Dictionary<string, string> datosAgente)
        {
            _sdk.fBuscaIdAgente(agenteId).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAgente().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAgente(datosAgente);
            _sdk.fGuardaAgente().ToResultadoSdk(_sdk).ThrowIfError();
        }

        public void Actualizar(string agenteCodigo, Dictionary<string, string> datosAgente)
        {
            _sdk.fBuscaAgente(agenteCodigo).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fEditaAgente().ToResultadoSdk(_sdk).ThrowIfError();
            SetDatosAgente(datosAgente);
            _sdk.fGuardaAgente().ToResultadoSdk(_sdk).ThrowIfError();
        }

        private void SetDatosAgente(Dictionary<string, string> datosAgente)
        {
            foreach (var dato in datosAgente)
            {
                _sdk.fSetDatoAgente(dato.Key, dato.Value);
            }
        }
    }
}