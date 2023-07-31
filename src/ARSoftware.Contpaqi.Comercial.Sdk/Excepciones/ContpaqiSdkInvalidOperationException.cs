using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;

public class ContpaqiSdkInvalidOperationException : ContpaqiSdkException
{
    public ContpaqiSdkInvalidOperationException() : base(0)
    {
    }

    public ContpaqiSdkInvalidOperationException(string message) : base(0, message)
    {
    }

    public ContpaqiSdkInvalidOperationException(string message, Exception innerException) : base(0, message, innerException)
    {
    }
}
