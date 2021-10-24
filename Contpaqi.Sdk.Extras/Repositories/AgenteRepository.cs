using System.Collections.Generic;
using System.Text;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class AgenteRepository : IAgenteRepository<Agente>
    {
        private readonly IContpaqiSdk _sdk;

        public AgenteRepository(IContpaqiSdk sdk)
        {
            _sdk = sdk;
        }

        public Agente BuscarPorId(int idAgente)
        {
            return _sdk.fBuscaIdAgente(idAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
        }

        public Agente BuscarPorCodigo(string codigoAgente)
        {
            return _sdk.fBuscaAgente(codigoAgente) == SdkResultConstants.Success ? LeerDatosAgenteActual() : null;
        }

        public IEnumerable<Agente> TraerTodo()
        {
            _sdk.fPosPrimerAgente().ToResultadoSdk(_sdk).ThrowIfError();
            yield return LeerDatosAgenteActual();

            while (_sdk.fPosSiguienteAgente() == SdkResultConstants.Success)
            {
                yield return LeerDatosAgenteActual();
                if (_sdk.fPosEOFAgente() == 1)
                {
                    break;
                }
            }
        }

        private Agente LeerDatosAgenteActual()
        {
            var id = new StringBuilder(12);
            var codigo = new StringBuilder(31);
            var nombre = new StringBuilder(61);
            var tipo = new StringBuilder(7);

            _sdk.fLeeDatoAgente("CIDAGENTE", id, 12).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoAgente("CCODIGOAGENTE", codigo, 31).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoAgente("CNOMBREAGENTE", nombre, 61).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoAgente("CTIPOAGENTE", tipo, 7).ToResultadoSdk(_sdk).ThrowIfError();

            var agente = new Agente();
            agente.Id = int.Parse(id.ToString());
            agente.Codigo = codigo.ToString();
            agente.Nombre = nombre.ToString();
            agente.Tipo = TipoAgenteEnumHelper.ToTipoAgente(tipo.ToString());
            return agente;
        }
    }
}