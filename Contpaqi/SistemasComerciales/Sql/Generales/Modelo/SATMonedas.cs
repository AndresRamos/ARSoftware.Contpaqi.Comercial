namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;

    public partial class SATMonedas
    {
        [Key]
        [StringLength(3)]
        public string CCODIGO { get; set; }

        [Required]
        [StringLength(100)]
        public string CNOMBRE { get; set; }
    }
}