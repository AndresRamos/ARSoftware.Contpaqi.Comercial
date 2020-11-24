using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteRepositorio
    {
        Agente BuscarAgente(int idAgente);
        Agente BuscarAgente(string codigoAgente);
        IEnumerable<Agente> TraerAgentes();
    }
}