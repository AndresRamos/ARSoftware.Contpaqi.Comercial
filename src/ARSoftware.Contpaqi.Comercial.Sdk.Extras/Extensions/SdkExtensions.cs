using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

public static class SdkExtensions
{
    public static object ConvertFromSdkValueString(this string valor, Type type)
    {
        if (type == typeof(DateTime)) return SdkDateTimeHelper.ConvertFromSdkFecha(valor);

        try
        {
            return TypeDescriptor.GetConverter(type).ConvertFromString(valor)!;
        }
        catch (ArgumentException)
        {
            // En Factura Electronica el SDK puede retornar strings vacios en colunas que son de tipo int
            // En vez de tirar una Exception regresar 0
            // Por el momento solo regresar el valor default cuando el tipo es int.
            if (type == typeof(int)) return 0;

            throw;
        }
    }

    /// <summary>
    ///     https://stackoverflow.com/questions/15341028/check-if-a-property-exists-in-a-class
    /// </summary>
    public static bool HasProperty(this Type obj, string propertyName)
    {
        return obj.GetProperty(propertyName) != null;
    }

    public static Dictionary<string, string> ToDatosDictionary<TModel>(this object model)
    {
        var datosDictionary = new Dictionary<string, string>();

        Type sqlModelType = typeof(TModel);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(model))
        {
            if (!sqlModelType.HasProperty(propertyDescriptor.Name) || propertyDescriptor.Name == "CTIMESTAMP") continue;

            string? propetyValue;

            if (propertyDescriptor.PropertyType == typeof(DateTime))
            {
                var value = (DateTime?)propertyDescriptor.GetValue(model);
                propetyValue = value?.ToSdkFecha();
            }
            else
                propetyValue = propertyDescriptor.GetValue(model)?.ToString();

            if (propetyValue is null) continue;

            datosDictionary.Add(propertyDescriptor.Name, propetyValue);
        }

        return datosDictionary;
    }
}
