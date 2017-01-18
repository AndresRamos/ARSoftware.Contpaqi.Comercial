namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;

    public partial class SATBancos
    {
        [Key]
        [StringLength(3)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBRE { get; set; }

        [Required]
        [StringLength(150)]
        public string CDESCRIPCION { get; set; }
    }
}
