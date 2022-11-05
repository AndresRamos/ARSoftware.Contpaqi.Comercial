using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Excepciones
{
    public class ContpaqiSdkExcepcion : Exception
    {
        public ContpaqiSdkExcepcion(int? codigoErrorSdk)
        {
            CodigoErrorSdk = codigoErrorSdk;
        }

        public ContpaqiSdkExcepcion(int? codigoErrorSdk, string message) : base(message)
        {
            CodigoErrorSdk = codigoErrorSdk;
            MensajeErrorSdk = message;
        }

        public ContpaqiSdkExcepcion(int? codigoErrorSdk, string message, Exception innerException) : base(message, innerException)
        {
            CodigoErrorSdk = codigoErrorSdk;
            MensajeErrorSdk = message;
        }

        public int? CodigoErrorSdk { get; }
        public string MensajeErrorSdk { get; }
    }
}
