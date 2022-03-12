using System;
using Contpaqi.Sdk.Extras.Helpers;

namespace Contpaqi.Sdk.Extras.Extensions
{
    public static class SdkDateTimeExtensions
    {
        public static string ToSdkFecha(this DateTime fecha)
        {
            return SdkDateTimeHelper.ConvertToSdkFecha(fecha);
        }
    }
}
