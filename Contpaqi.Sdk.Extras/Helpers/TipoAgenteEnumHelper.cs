using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class TipoAgenteEnumHelper
    {
        public static TipoAgenteEnum ToTipoAgente(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoAgenteEnum tipoAgenteEnum);

            if (result)
            {
                return tipoAgenteEnum;
            }

            throw new InvalidOperationException($"El tipo {tipo} no es un tipo de agente valido.");
        }
    }
}