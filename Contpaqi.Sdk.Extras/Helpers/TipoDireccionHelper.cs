using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class TipoDireccionHelper
    {
        public static TipoDireccionEnum ToTipoDireccion(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoDireccionEnum tipoDireccionEnum);

            if (result)
            {
                return tipoDireccionEnum;
            }

            throw new InvalidOperationException($"El tipo {tipo} no es un tipo de direccion valido.");
        }
    }
}