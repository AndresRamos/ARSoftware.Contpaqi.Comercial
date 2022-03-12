using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Exceptions
{
    public class ContpaqiSdkException : Exception
    {
        public ContpaqiSdkException(int? numeroErrorSdk)
        {
            NumeroErrorSdk = numeroErrorSdk;
        }

        public ContpaqiSdkException(int? numeroErrorSdk, string message) : base(message)
        {
            NumeroErrorSdk = numeroErrorSdk;
        }

        public ContpaqiSdkException(int? numeroErrorSdk, string message, Exception innerException) : base(message, innerException)
        {
            NumeroErrorSdk = numeroErrorSdk;
        }

        public int? NumeroErrorSdk { get; set; }
    }
}
