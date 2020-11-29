using Contpaqi.Sdk.Extras.Interfaces;

namespace Contpaqi.Sdk.Extras.Models
{
    public class ValorClasificacion : IValorClasificacion
    {
        public int Id { get; set; }

        public int IdClasificacion { get; set; }

        public string Codigo { get; set; }

        public string Valor { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Valor}";
        }
    }
}