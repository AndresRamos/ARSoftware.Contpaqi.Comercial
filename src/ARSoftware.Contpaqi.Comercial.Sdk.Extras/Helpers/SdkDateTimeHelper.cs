using System;
using System.Globalization;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class SdkDateTimeHelper
{
    public static DateTime ConvertFromSdkFecha(string fecha)
    {
        return DateTime.ParseExact(fecha, new[] { FormatosFechaSdk.Comercial, FormatosFechaSdk.FacturaElectronica }, null,
            DateTimeStyles.None);
    }

    public static string ConvertToSdkFecha(DateTime fecha)
    {
        return fecha.ToString(FormatosFechaSdk.Fecha);
    }

    /// <summary>
    ///     Crea la fecha predeterminada del SDK cuando no se le asigna un valor.
    /// </summary>
    /// <returns>Fecha Predeterminada = new DateTime(1899, 12, 30)</returns>
    public static DateTime CreateDefaultSdkFecha()
    {
        return new DateTime(1899, 12, 30);
    }
}
