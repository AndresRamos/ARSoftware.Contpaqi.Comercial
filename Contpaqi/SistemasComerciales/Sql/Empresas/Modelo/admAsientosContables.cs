namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admAsientosContables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDASIENTOCONTABLE { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROASIENTOCONTABLE { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREASIENTOCONTABLE { get; set; }

        public int CFRECUENCIA { get; set; }

        public int CORIGENFECHA { get; set; }

        public int CTIPOPOLIZA { get; set; }

        public int CORIGENNUMERO { get; set; }

        public int CORIGENCONCEPTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CCONCEPTO { get; set; }

        [Required]
        [StringLength(10)]
        public string CDIARIO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}
