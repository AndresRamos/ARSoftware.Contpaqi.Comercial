using System;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class SdkDateTimeHelper
    {
        public static string ToSdkString(this DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }
    }
}