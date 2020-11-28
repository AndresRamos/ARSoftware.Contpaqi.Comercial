using System;
using Contpaqi.Sdk.Extras.Modelos.Enums;

namespace Contpaqi.Sdk.Extras.Ayudantes
{
    public static class TipoProductoHelper
    {
        public static string ToSdkString(this TipoProductoEnum tipo)
        {
            return ((int) tipo).ToString();
        }

        public static TipoProductoEnum ToTipoProductoEnum(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoProductoEnum tipoProducto);

            if (result)
            {
                return tipoProducto;
            }

            throw new InvalidOperationException("El tipo {tipo} no es un tipo de producto valido.");
        }

        public static bool EsProducto(string tipoDeProducto)
        {
            return tipoDeProducto == TipoProductoEnum.Producto.ToSdkString();
        }

        public static bool EsPaquete(string tipoDeProducto)
        {
            return tipoDeProducto == TipoProductoEnum.Paquete.ToSdkString();
        }

        public static bool EsServicio(string tipoDeProducto)
        {
            return tipoDeProducto == TipoProductoEnum.Servicio.ToSdkString();
        }
    }
}