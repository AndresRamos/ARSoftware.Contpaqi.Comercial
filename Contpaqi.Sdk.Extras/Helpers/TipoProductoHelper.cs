using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class TipoProductoHelper
    {
        public static TipoProductoEnum ConvertoToTipoProductoEnum(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoProductoEnum tipoProducto);

            if (result)
            {
                return tipoProducto;
            }

            throw new InvalidOperationException($"El tipo {tipo} no es un tipo de producto valido.");
        }

        public static bool IsProducto(string tipoDeProducto)
        {
            return ConvertoToTipoProductoEnum(tipoDeProducto) == TipoProductoEnum.Producto;
        }

        public static bool IsPaquete(string tipoDeProducto)
        {
            return ConvertoToTipoProductoEnum(tipoDeProducto) == TipoProductoEnum.Paquete;
        }

        public static bool IsServicio(string tipoDeProducto)
        {
            return ConvertoToTipoProductoEnum(tipoDeProducto) == TipoProductoEnum.Servicio;
        }
    }
}