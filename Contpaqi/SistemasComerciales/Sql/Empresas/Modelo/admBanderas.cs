namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admBanderas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDBANDERA { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBREBANDERA { get; set; }

        [Column(TypeName = "text")]
        public string CBANDERA { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVEISO { get; set; }
    }
}
