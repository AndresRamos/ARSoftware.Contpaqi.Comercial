using System;
using System.Runtime.Serialization;

namespace Contpaqi.Sdk.Extras.Excepciones
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

        protected ContpaqiSdkException(int? numeroErrorSdk, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            NumeroErrorSdk = numeroErrorSdk;
        }

        public int? NumeroErrorSdk { get; set; }
    }
}