namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admDocumentosXMLTemp")]
    public partial class admDocumentosXMLTemp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDFOLDIG { get; set; }

        [Required]
        [StringLength(1)]
        public string CTIPO { get; set; }

        public DateTime CFECHAEMI { get; set; }

        [Required]
        [StringLength(8)]
        public string CHORAEMI { get; set; }

        [Required]
        [StringLength(25)]
        public string CSERIEREC { get; set; }

        public int CFOLIOREC { get; set; }

        public int CESTRAD { get; set; }

        [Required]
        [StringLength(253)]
        public string CRAZON { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        public int CNOAPROB { get; set; }

        public DateTime CFECAPROB { get; set; }

        public double CTOTAL { get; set; }

        [Required]
        [StringLength(253)]
        public string CARCHDIDIS { get; set; }

        public int CERROR { get; set; }

        public int CTIPOERROR { get; set; }

        [Required]
        [StringLength(253)]
        public string CDESCERROR { get; set; }

        public int CIDFIRMAR { get; set; }

        public int CCFDPRUEBA { get; set; }

        [Required]
        [StringLength(253)]
        public string CRAZONRECE { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFCRECE { get; set; }

        [Required]
        [StringLength(30)]
        public string CNOSERCERT { get; set; }

        [Required]
        [StringLength(60)]
        public string CUUID { get; set; }

        public int CERRORVAL { get; set; }
    }
}
