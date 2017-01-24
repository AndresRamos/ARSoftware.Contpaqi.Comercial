namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Folios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        public int IdDocumentoDe { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? NoAprobacion { get; set; }

        [StringLength(15)]
        public string Serie { get; set; }

        public bool? UsaRango { get; set; }

        [StringLength(20)]
        public string FolioActual { get; set; }

        [StringLength(20)]
        public string FolioInicial { get; set; }

        [StringLength(20)]
        public string FolioFinal { get; set; }

        public int? TipoGeneracion { get; set; }
    }
}