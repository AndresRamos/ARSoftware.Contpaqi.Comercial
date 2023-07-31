using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class EstatusHelper
{
    public static Estatus ConvertFromSdkValue(string sdkEstatus)
    {
        bool result = Enum.TryParse(sdkEstatus, true, out Estatus estatus);

        if (result) return estatus;

        throw new InvalidOperationException($"El estatus {estatus} no es un estatus valido.");
    }

    public static Estatus ConvertFromSdkValue(int sdkEstatus)
    {
        return ConvertFromSdkValue(sdkEstatus.ToString());
    }

    public static int ConvertToSdkValue(Estatus estatus)
    {
        return (int)estatus;
    }
}
