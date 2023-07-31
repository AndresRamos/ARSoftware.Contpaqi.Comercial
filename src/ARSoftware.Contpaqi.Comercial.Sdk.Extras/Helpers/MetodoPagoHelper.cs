using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class MetodoPagoHelper
{
    public static MetodoPago? ConvertFromSdkValue(string sdkMetodo)
    {
        switch (sdkMetodo)
        {
            case "1":
                return MetodoPago.PUE;
            case "2":
                return MetodoPago.PPD;
            default:
                return null;
        }
    }

    public static MetodoPago? ConvertFromSdkValue(int sdkMetodo)
    {
        return ConvertFromSdkValue(sdkMetodo.ToString());
    }

    public static int ConvertToSdkValue(MetodoPago metodo)
    {
        if (metodo == MetodoPago.PUE) return 1;
        if (metodo == MetodoPago.PPD) return 2;
        throw new ArgumentException("El metodo no es valido.", nameof(metodo));
    }
}
