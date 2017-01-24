namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admFoliosDigitales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDFOLDIG { get; set; }

        public int CIDDOCTODE { get; set; }

        public int CIDCPTODOC { get; set; }

        public int CIDDOCTO { get; set; }

        public int CIDDOCALDI { get; set; }

        public int CIDFIRMARL { get; set; }

        public int CNOORDEN { get; set; }

        [Required]
        [StringLength(10)]
        public string CSERIE { get; set; }

        public double CFOLIO { get; set; }

        public int CNOAPROB { get; set; }

        public DateTime CFECAPROB { get; set; }

        public int CESTADO { get; set; }

        public int CENTREGADO { get; set; }

        public DateTime CFECHAEMI { get; set; }

        [Required]
        [StringLength(8)]
        public string CHORAEMI { get; set; }

        [Required]
        [StringLength(60)]
        public string CEMAIL { get; set; }

        [Required]
        [StringLength(253)]
        public string CARCHDIDIS { get; set; }

        public int CIDCPTOORI { get; set; }

        public DateTime CFECHACANC { get; set; }

        [Required]
        [StringLength(8)]
        public string CHORACANC { get; set; }

        public int CESTRAD { get; set; }

        [Column(TypeName = "text")]
        public string CCADPEDI { get; set; }

        [Required]
        [StringLength(60)]
        public string CARCHCBB { get; set; }

        public DateTime CINIVIG { get; set; }

        public DateTime CFINVIG { get; set; }

        [Required]
        [StringLength(1)]
        public string CTIPO { get; set; }

        [Required]
        [StringLength(25)]
        public string CSERIEREC { get; set; }

        public double CFOLIOREC { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(253)]
        public string CRAZON { get; set; }

        public int CSISORIGEN { get; set; }

        public int CEJERPOL { get; set; }

        public int CPERPOL { get; set; }

        public int CTIPOPOL { get; set; }

        public int CNUMPOL { get; set; }

        [Required]
        [StringLength(100)]
        public string CTIPOLDESC { get; set; }

        public double CTOTAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CALIASBDCT { get; set; }

        public int CCFDPRUEBA { get; set; }

        [Required]
        [StringLength(50)]
        public string CDESESTADO { get; set; }

        public int CPAGADOBAN { get; set; }

        [Required]
        [StringLength(20)]
        public string CDESPAGBAN { get; set; }

        [Required]
        [StringLength(20)]
        public string CREFEREN01 { get; set; }

        [Required]
        [StringLength(253)]
        public string COBSERVA01 { get; set; }

        [Required]
        [StringLength(30)]
        public string CCODCONCBA { get; set; }

        [Required]
        [StringLength(100)]
        public string CDESCONCBA { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMCTABAN { get; set; }

        [Required]
        [StringLength(20)]
        public string CFOLIOBAN { get; set; }

        public int CIDDOCDEBA { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSUAUTBAN { get; set; }

        [Required]
        [StringLength(60)]
        public string CUUID { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSUBAN01 { get; set; }

        public int CAUTUSBA01 { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSUBAN02 { get; set; }

        public int CAUTUSBA02 { get; set; }

        [Required]
        [StringLength(20)]
        public string CUSUBAN03 { get; set; }

        public int CAUTUSBA03 { get; set; }

        [Required]
        [StringLength(20)]
        public string CDESCAUT01 { get; set; }

        [Required]
        [StringLength(20)]
        public string CDESCAUT02 { get; set; }

        [Required]
        [StringLength(20)]
        public string CDESCAUT03 { get; set; }

        public int CERRORVAL { get; set; }

        [Required]
        [StringLength(30)]
        public string CACUSECAN { get; set; }

        [Required]
        [StringLength(40)]
        public string CIDDOCTODSL { get; set; }
    }
}