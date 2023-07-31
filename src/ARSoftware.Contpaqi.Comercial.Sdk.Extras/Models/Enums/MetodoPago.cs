using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

public class MetodoPago
{
    /// <summary>
    ///     PUE - Pago en una sola exhibición
    /// </summary>
    public static readonly MetodoPago PUE = new("PUE", "Pago en una sola exhibición");

    /// <summary>
    ///     PPD - Pago en parcialidades o diferido
    /// </summary>
    public static readonly MetodoPago PPD = new("PPD", "Pago en parcialidades o diferido");

    public MetodoPago(string clave, string descripcion)
    {
        Clave = clave;
        Descripcion = descripcion;
    }

    public string Clave { get; }
    public string Descripcion { get; }

    public static MetodoPago? FromClave(string clave)
    {
        return ToList().SingleOrDefault(r => r.Clave == clave);
    }

    public static MetodoPago? FromDescripcion(string descripcion)
    {
        return ToList().SingleOrDefault(r => string.Equals(r.Descripcion, descripcion, StringComparison.OrdinalIgnoreCase));
    }

    public static List<MetodoPago> ToList()
    {
        return typeof(MetodoPago).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(p => p.FieldType == typeof(MetodoPago))
            .Select(pi => (MetodoPago)pi.GetValue(null)!)
            .OrderBy(p => p.Clave)
            .ToList();
    }

    public override string ToString()
    {
        return $"{Clave} - {Descripcion}";
    }
}
