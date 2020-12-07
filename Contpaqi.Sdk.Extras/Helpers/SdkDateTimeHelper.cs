using System;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class SdkDateTimeHelper
    {
        public static string ToSdkString(this DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }

        public static DateTime FromSdkCatalogoString(string fecha)
        {
            return DateTime.ParseExact(fecha, "MM/dd/yy", null);
        }

        public static DateTime FromSdkDocumentoString(string fecha)
        {
            return DateTime.ParseExact(fecha, "M/d/yyyy HH:mm:ss:fff", null);
        }
    }
}