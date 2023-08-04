using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

public static class SdkDateTimeExtensions
{
    public static string ToSdkFecha(this DateTime fecha)
    {
        return SdkDateTimeHelper.ConvertToSdkFecha(fecha);
    }
}
