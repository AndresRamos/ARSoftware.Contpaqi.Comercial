using System;

namespace Contpaqi.SistemasComerciales.Sdk.Extras.Excepciones
{
    public class SistemasComercialesSdkException : Exception
    {
        public SistemasComercialesSdkException(int? error) : base()
        {
            ErrorSdk = error;
        }

        public SistemasComercialesSdkException(int? error, string mensage) : base(mensage)
        {
            ErrorSdk = error;
        }

        public SistemasComercialesSdkException(int? error, string mensage, Exception inner) : base(mensage, inner)
        {
            ErrorSdk = error;
        }

        public int? ErrorSdk { get; set; }
    }
}