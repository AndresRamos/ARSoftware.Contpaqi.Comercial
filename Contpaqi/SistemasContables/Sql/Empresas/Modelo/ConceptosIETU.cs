namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ConceptosIETU")]
    public partial class ConceptosIETU
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int? Tipo { get; set; }

        public int? TipoFlujo { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
