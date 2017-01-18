namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Empresas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEMPRESA { get; set; }

        [Required]
        [StringLength(150)]
        public string CNOMBREEMPRESA { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTADATOS { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTARESPALDOS { get; set; }
    }
}
