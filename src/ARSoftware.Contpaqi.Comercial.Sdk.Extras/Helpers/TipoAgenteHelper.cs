using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class TipoAgenteHelper
{
    public static TipoAgente ConvertFromSdkValue(string sdkTipo)
    {
        bool result = Enum.TryParse(sdkTipo, true, out TipoAgente tipoAgente);

        if (result) return tipoAgente;

        throw new InvalidOperationException($"El tipo {sdkTipo} no es un tipo de agente valido.");
    }

    public static TipoAgente ConvertFromSdkValue(int sdkTipo)
    {
        return ConvertFromSdkValue(sdkTipo.ToString());
    }

    public static int ConvertToSdkValue(TipoAgente tipo)
    {
        return (int)tipo;
    }
}
