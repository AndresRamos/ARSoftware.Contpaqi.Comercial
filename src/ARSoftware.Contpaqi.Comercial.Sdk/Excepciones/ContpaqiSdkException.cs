using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;

/// <summary>
///     Excepcion del SDK.
/// </summary>
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

    /// <summary>
    ///     Codigo de error del SDK.
    /// </summary>
    public int CodigoErrorSdk { get; }

    /// <summary>
    ///     Mensaje de error del codigo de error del SDK.
    /// </summary>
    public string MensajeErrorSdk { get; } = string.Empty;
}
