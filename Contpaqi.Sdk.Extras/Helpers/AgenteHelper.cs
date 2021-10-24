using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class AgenteHelper
    {
        public static Dictionary<string, string> ToDatosDictionary(this Agente agente)
        {
            var datosAgente = new Dictionary<string, string>();
            datosAgente.Add("CIDAGENTE", agente.Id.ToString());
            datosAgente.Add("CCODIGOAGENTE", agente.Codigo);
            datosAgente.Add("CNOMBREAGENTE", agente.Nombre);
            datosAgente.Add("CTIPOAGENTE", ((int)agente.Tipo).ToString());
            return datosAgente;
        }
    }
}