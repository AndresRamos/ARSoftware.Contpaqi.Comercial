namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admMonedas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMONEDA { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREMONEDA { get; set; }

        [Required]
        [StringLength(1)]
        public string CSIMBOLOMONEDA { get; set; }

        public int CPOSICIONSIMBOLO { get; set; }

        [Required]
        [StringLength(60)]
        public string CPLURAL { get; set; }

        [Required]
        [StringLength(60)]
        public string CSINGULAR { get; set; }

        [Required]
        [StringLength(60)]
        public string CDESCRIPCIONPROTEGIDA { get; set; }

        public int CIDBANDERA { get; set; }

        public int CDECIMALESMONEDA { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVESAT { get; set; }
    }
}
