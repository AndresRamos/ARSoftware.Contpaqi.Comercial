using System;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class Moneda
    {
        public static readonly Moneda Ninguna = new Moneda(0, "(Ninguna)");
        public static readonly Moneda PesoMexicano = new Moneda(1, "Peso Mexicano");
        public static readonly Moneda DolarAmericano = new Moneda(2, "Dólar Americano");

        public Moneda()
        {
        }

        public Moneda(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public static IEnumerable<Moneda> ToList()
        {
            yield return Ninguna;
            yield return PesoMexicano;
            yield return DolarAmericano;
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
}
