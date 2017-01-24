namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admVistasCampos
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
        public string CNOMBRENATIVOTABLA { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(51)]
        public string CNOMBRENATIVOCAMPO { get; set; }

        [Required]
        [StringLength(51)]
        public string CNOMBREAMIGABLECAMPO { get; set; }

        public int CANCHOCA01 { get; set; }

        public int CCAMPOOC01 { get; set; }

        public int CCAMPOOR01 { get; set; }

        public int CTIPOCAMPO { get; set; }

        public int CCALCULADO { get; set; }

        public int CDECIMALES { get; set; }

        public int CALINEAR { get; set; }

        public int CFORMATEAR { get; set; }
    }
}