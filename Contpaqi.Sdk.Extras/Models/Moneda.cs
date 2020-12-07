using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Moneda : IMoneda
    {
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

        public static Moneda Ninguna { get; } = new Moneda(0, "(Ninguna)");
        public static Moneda PesoMexicano { get; } = new Moneda(1, "Peso Mexicano");
        public static Moneda DolarAmericano { get; } = new Moneda(2, "Dólar Americano");

        public override string ToString()
        {
            return Nombre;
        }

        public static IEnumerable<Moneda> ToList()
        {
            yield return Ninguna;
            yield return PesoMexicano;
            yield return DolarAmericano;
        }
    }
}