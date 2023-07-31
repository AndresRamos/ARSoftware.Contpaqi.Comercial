using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class TipoDireccionHelper
{
    public static TipoDireccion ConvertFromSdkValue(string sdkTipo)
    {
        bool result = Enum.TryParse(sdkTipo, true, out TipoDireccion tipoDireccion);

        if (result) return tipoDireccion;

        throw new InvalidOperationException($"El tipo {sdkTipo} no es un tipo de direccion valido.");
    }

    public static TipoDireccion ConvertFromSdkValue(int sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo.ToString());
    }

    public static int ConvertToSdkValue(TipoDireccion tipo)
    {
        return (int)tipo;
    }
}
