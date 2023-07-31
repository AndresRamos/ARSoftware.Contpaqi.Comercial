using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class TipoCatalogoDireccionHelper
{
    public static TipoCatalogoDireccion ConvertFromSdkValue(string sdkTipo)
    {
        bool result = Enum.TryParse(sdkTipo, true, out TipoCatalogoDireccion tipoCatalogoDireccion);

        if (result) return tipoCatalogoDireccion;

        throw new InvalidOperationException($"El tipo {sdkTipo} no es un tipo de direccion valido.");
    }

    public static TipoCatalogoDireccion ConvertFromSdkValue(int sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo.ToString());
    }

    public static int ConvertToSdkValue(TipoCatalogoDireccion tipo)
    {
        return (int)tipo;
    }
}
