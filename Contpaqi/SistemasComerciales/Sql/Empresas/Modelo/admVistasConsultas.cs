namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admVistasConsultas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCONSULTA { get; set; }

        public int CIDSISTEMA { get; set; }

        public int CIDIDIOMA { get; set; }

        public int CIDMODULO { get; set; }

        public int CTIPO { get; set; }

        public int CCOLUMNASOCULTAR { get; set; }

        [Required]
        [StringLength(51)]
        public string CNOMBRECONSULTA { get; set; }

        [Column(TypeName = "text")]
        public string CSENTENCIASQL { get; set; }

        public int CIDEMPRESA { get; set; }

        [Required]
        [StringLength(26)]
        public string CINDICE { get; set; }

        public int CESDESIS01 { get; set; }

        [Required]
        [StringLength(128)]
        public string CFILTROS { get; set; }

        public int CINICIOARG { get; set; }

        public int CLIMITEARG { get; set; }

        public int CORDEN { get; set; }
    }
}
