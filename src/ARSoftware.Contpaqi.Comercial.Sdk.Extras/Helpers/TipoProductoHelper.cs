using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class TipoProductoHelper
{
    public static TipoProducto ConvertFromSdkValue(string sdkTipo)
    {
        bool result = Enum.TryParse(sdkTipo, true, out TipoProducto tipoProducto);

        if (result) return tipoProducto;

        throw new InvalidOperationException($"El tipo {sdkTipo} no es un tipo de producto valido.");
    }

    public static TipoProducto ConvertFromSdkValue(int sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo.ToString());
    }

    public static int ConvertToSdkValue(TipoProducto tipoProducto)
    {
        return (int)tipoProducto;
    }

    public static bool IsPaquete(string sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo) == TipoProducto.Paquete;
    }

    public static bool IsProducto(string sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo) == TipoProducto.Producto;
    }

    public static bool IsServicio(string sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo) == TipoProducto.Servicio;
    }
}
