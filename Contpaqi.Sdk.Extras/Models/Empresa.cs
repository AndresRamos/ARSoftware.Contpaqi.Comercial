using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class Empresa : IEmpresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ruta { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}