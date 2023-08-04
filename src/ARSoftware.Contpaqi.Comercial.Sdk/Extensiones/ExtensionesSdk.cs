using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extensiones;

public static class ExtensionesSdk
{
    public static TipoContpaqiSdk TipoSdk = TipoContpaqiSdk.Comercial;

    /// <summary>
    ///     Tira una ContpaqiSdkException si el valor del int es un codigo de error.
    ///     Utiliza el SDK asignado en TipoSdk.
    /// </summary>
    /// <param name="codigoErrorSdk">El codigo de retorno de una funcion del SDK</param>
    /// <exception cref="ContpaqiSdkException">
    ///     Si el codigo es un codigo de error error tira una ContpaqiSdkExcepcion con el mensaje del error.
    /// </exception>
    public static void TirarSiEsError(this int codigoErrorSdk)
    {
        if (codigoErrorSdk == 0) return;

        var mensajeError = new StringBuilder(512);

        if (TipoSdk == TipoContpaqiSdk.Comercial)
            ComercialSdk.fError(codigoErrorSdk, mensajeError, 512);
        else
            AdminpaqSdk.fError(codigoErrorSdk, mensajeError, 512);

        throw new ContpaqiSdkException(codigoErrorSdk, mensajeError.ToString());
    }

    /// <summary>
    ///     Tira una ContpaqiSdkException si el valor del int es un codigo de error.
    /// </summary>
    /// <param name="codigoErrorSdk">El codigo de retorno de una funcion del SDK</param>
    /// <param name="contpaqiSdk">El SDK a utilizar.</param>
    /// <exception cref="ContpaqiSdkException">
    ///     Si el codigo es un codigo de error error tira una ContpaqiSdkExcepcion con el mensaje del error.
    /// </exception>
    public static void TirarSiEsError(this int codigoErrorSdk, TipoContpaqiSdk contpaqiSdk)
    {
        if (codigoErrorSdk == 0) return;

        var mensajeError = new StringBuilder(512);

        if (contpaqiSdk == TipoContpaqiSdk.Comercial)
            ComercialSdk.fError(codigoErrorSdk, mensajeError, 512);
        else
            AdminpaqSdk.fError(codigoErrorSdk, mensajeError, 512);

        throw new ContpaqiSdkException(codigoErrorSdk, mensajeError.ToString());
    }
}
