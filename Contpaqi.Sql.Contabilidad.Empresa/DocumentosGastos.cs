namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentosGastos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(40)]
        public string CodigoPersona { get; set; }

        public int TipoDeGasto { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime FechaApertura { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        public int? IdDocumentoDe { get; set; }

        public int? IdCuentaDocumentoBancario { get; set; }

        [StringLength(30)]
        public string TipoDocumentoBancario { get; set; }

        [StringLength(20)]
        public string FolioDocumentoBancario { get; set; }

        public int? IdPoliza { get; set; }

        public DateTime? FechaCierre { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }
    }
}
