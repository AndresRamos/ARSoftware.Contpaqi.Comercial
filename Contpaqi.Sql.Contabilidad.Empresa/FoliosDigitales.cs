namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoliosDigitales
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        public int? IdDocumentoDe { get; set; }

        [StringLength(30)]
        public string CodigoTipoDocumento { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int NoAprobacion { get; set; }

        public int AnioAprobacion { get; set; }

        [StringLength(15)]
        public string Serie { get; set; }

        [StringLength(20)]
        public string FolioActual { get; set; }

        [StringLength(20)]
        public string FolioInicial { get; set; }

        [StringLength(20)]
        public string FolioFinal { get; set; }

        public bool? EsFiscal { get; set; }
    }
}
