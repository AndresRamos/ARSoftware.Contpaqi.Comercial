using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Almacen : IAlmacen
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }
    }
}