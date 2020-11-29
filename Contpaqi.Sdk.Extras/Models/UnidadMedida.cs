using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class UnidadMedida : IUnidadMedida
    {
        // Propiedades tUnidad

        public string Nombre { get; set; }

        public string Abreviatura { get; set; }

        public string Despliegue { get; set; }

        // Propiedades Extra

        public int Id { get; set; }

        public string ClaveSat { get; set; }

        public string ClaveSatComercioExterior { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}