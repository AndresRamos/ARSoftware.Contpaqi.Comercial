using System;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Agente : admAgentes
    {
        public Agente()
        {
            CFECHAALTAAGENTE = DateTime.Today;
            CFECHAEXTRA = DateTime.Today;
            Tipo = TipoAgente.VentasCobro;
        }

        public TipoAgente Tipo
        {
            get => TipoAgenteHelper.ConvertFromSdkValue(CTIPOAGENTE);
            set => CTIPOAGENTE = TipoAgenteHelper.ConvertToSdkValue(value);
        }

        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CIDAGENTE.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CCODIGOAGENTE.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CNOMBREAGENTE.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CTIPOAGENTE.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public override string ToString()
        {
            return $"{CCODIGOAGENTE} - {CNOMBREAGENTE}";
        }
    }
}
