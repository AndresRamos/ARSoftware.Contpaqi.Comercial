using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class MetodoPagoHelper
{
    public static MetodoPagoEnum? ConvertFromSdkValue(string sdkMetodo)
    {
        switch (sdkMetodo)
        {
            case "1":
                return MetodoPagoEnum.PUE;
            case "2":
                return MetodoPagoEnum.PPD;
            default:
                return null;
        }
    }

    public static MetodoPagoEnum? ConvertFromSdkValue(int sdkMetodo)
    {
        return ConvertFromSdkValue(sdkMetodo.ToString());
    }

    public static int ConvertToSdkValue(MetodoPagoEnum metodo)
    {
        if (metodo == MetodoPagoEnum.PUE) return 1;
        if (metodo == MetodoPagoEnum.PPD) return 2;
        throw new ArgumentException("El metodo no es valido.", nameof(metodo));
    }
}
