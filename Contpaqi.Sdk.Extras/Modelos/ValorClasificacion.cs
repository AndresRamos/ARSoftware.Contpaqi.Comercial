namespace Contpaqi.Sdk.Extras.Modelos
{
    public class ValorClasificacion
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