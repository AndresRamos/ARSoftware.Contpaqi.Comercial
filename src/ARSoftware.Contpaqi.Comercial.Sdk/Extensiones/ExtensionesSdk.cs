using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extensiones
{
    public static class ExtensionesSdk
    {
        public static TipoContpaqiSdk TipoSdk = TipoContpaqiSdk.Comercial;

        /// <summary>
        ///     Tira una ContpaqiSdkExcepcion si el valor del int es un codigo de error.
        /// </summary>
        /// <param name="codigoErrorSdk">El codigo de retorno de una funcion del SDK</param>
        /// <exception cref="ContpaqiSdkExcepcion">
        ///     Si el codigo es un codigo de error error tira una ContpaqiSdkExcepcion con el mensaje del error.
        /// </exception>
        public static void TirarSiEsError(this int codigoErrorSdk)
        {
            if (codigoErrorSdk == 0)
                return;

            var mensajeError = new StringBuilder(512);

            if (TipoSdk == TipoContpaqiSdk.Comercial)
                ComercialSdk.fError(codigoErrorSdk, mensajeError, 512);
            else
                AdminpaqSdk.fError(codigoErrorSdk, mensajeError, 512);

            throw new ContpaqiSdkException(codigoErrorSdk, mensajeError.ToString());
        }
    }
}
