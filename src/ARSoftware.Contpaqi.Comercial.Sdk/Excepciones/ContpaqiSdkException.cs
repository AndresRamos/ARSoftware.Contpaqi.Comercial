using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Excepciones
{
    public class ContpaqiSdkException : Exception
    {
        public ContpaqiSdkException(int codigoErrorSdk)
        {
            CodigoErrorSdk = codigoErrorSdk;
        }

        public ContpaqiSdkException(int codigoErrorSdk, string message) : base(message)
        {
            CodigoErrorSdk = codigoErrorSdk;
            MensajeErrorSdk = message;
        }

        public ContpaqiSdkException(int codigoErrorSdk, string message, Exception innerException) : base(message, innerException)
        {
            CodigoErrorSdk = codigoErrorSdk;
            MensajeErrorSdk = message;
        }

        public int CodigoErrorSdk { get; }
        public string MensajeErrorSdk { get; } = string.Empty;
    }
}
