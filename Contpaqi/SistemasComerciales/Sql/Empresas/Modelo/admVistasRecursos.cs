namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admVistasRecursos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDSISTEMA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDIDIOMA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMODULO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(9)]
        public string CTABLABASE { get; set; }

        [Required]
        [StringLength(9)]
        public string CTABLARELA { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(26)]
        public string CCAMPOBASE { get; set; }

        [Required]
        [StringLength(26)]
        public string CCAMPOID { get; set; }

        [Required]
        [StringLength(41)]
        public string CTITULO0 { get; set; }

        [Required]
        [StringLength(26)]
        public string CCAMPO0 { get; set; }

        [Required]
        [StringLength(26)]
        public string CINDICE0 { get; set; }

        public int CANCHO0 { get; set; }

        [Required]
        [StringLength(41)]
        public string CTITULO1 { get; set; }

        [Required]
        [StringLength(26)]
        public string CCAMPO1 { get; set; }

        [Required]
        [StringLength(26)]
        public string CINDICE1 { get; set; }

        public int CANCHO1 { get; set; }

        [Required]
        [StringLength(51)]
        public string CRANGO { get; set; }
    }
}