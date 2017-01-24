namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
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
    }
}