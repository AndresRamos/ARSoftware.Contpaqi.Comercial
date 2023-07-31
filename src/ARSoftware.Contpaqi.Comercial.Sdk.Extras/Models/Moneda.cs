using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class Moneda
{
    public static readonly Moneda Ninguna = new(0, "(Ninguna)");
    public static readonly Moneda PesoMexicano = new(1, "Peso Mexicano");
    public static readonly Moneda DolarAmericano = new(2, "Dólar Americano");

    public Moneda()
    {
    }

    public Moneda(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    /// <summary>
    ///     Id de la moneda del documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Nombre de la moneda.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    public static List<Moneda> ToList()
    {
        return new List<Moneda> { Ninguna, PesoMexicano, DolarAmericano };
    }

    public static Moneda FromId(int id)
    {
        return ToList().Single(r => r.Id == id);
    }

    public static Moneda FromNombre(string nombre)
    {
        return ToList().Single(r => string.Equals(r.Nombre, nombre, StringComparison.OrdinalIgnoreCase));
    }

    public override string ToString()
    {
        return Nombre;
    }
}
