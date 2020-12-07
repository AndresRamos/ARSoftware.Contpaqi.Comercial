using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class TipoCatalogoDireccionHelper
    {
        public static TipoCatalogoDireccion ConvertToTipoCatalogoDireccion(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoCatalogoDireccion tipoCatalogoDireccion);

            if (result)
            {
                return tipoCatalogoDireccion;
            }

            throw new InvalidOperationException($"El tipo {tipo} no es un tipo de direccion valido.");
        }
    }
}