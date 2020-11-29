using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Clasificacion : IClasificacion
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<ValorClasificacion> Valores { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}