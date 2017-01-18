namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AsocComprasVentas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int? IdDocumento { get; set; }

        public int IdDocumentoDe { get; set; }

        [Required]
        [StringLength(30)]
        public string TipoDocumento { get; set; }

        public int IdCuentaCheques { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        [StringLength(30)]
        public string CodigoConceptoAdmin { get; set; }

        [StringLength(100)]
        public string ConceptoAdmin { get; set; }

        [StringLength(15)]
        public string SerieAdminPAQ { get; set; }

        [StringLength(20)]
        public string FolioAdminPAQ { get; set; }

        [StringLength(30)]
        public string CodigoConceptoPago { get; set; }

        [StringLength(23)]
        public string FechaAdminPAQ { get; set; }

        [StringLength(40)]
        public string CodigoCteProvAdminPAQ { get; set; }
    }
}
