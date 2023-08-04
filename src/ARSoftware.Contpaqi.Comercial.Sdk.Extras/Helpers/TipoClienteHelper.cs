using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class TipoClienteHelper
{
    public static TipoCliente ConvertFromSdkValue(string sdkTipo)
    {
        bool result = Enum.TryParse(sdkTipo, true, out TipoCliente tipoCliente);

        if (result) return tipoCliente;

        throw new InvalidOperationException($"El tipo {sdkTipo} no es un tipo de cliente valido.");
    }

    public static TipoCliente ConvertFromSdkValue(int sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo.ToString());
    }

    public static int ConvertToSdkValue(TipoCliente tipo)
    {
        return (int)tipo;
    }

    public static bool IsCliente(string sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo) == TipoCliente.Cliente || ConvertFromSdkValue(sdkTipo) == TipoCliente.ClienteProveedor;
    }

    public static bool IsProveedor(string sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo) == TipoCliente.Proveedor || ConvertFromSdkValue(sdkTipo) == TipoCliente.ClienteProveedor;
    }
}
