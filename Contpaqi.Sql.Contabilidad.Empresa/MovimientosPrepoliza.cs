namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientosPrepoliza")]
    public partial class MovimientosPrepoliza
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdPrepoliza { get; set; }

        public int NumMovto { get; set; }

        [Required]
        [StringLength(52)]
        public string Cuenta { get; set; }

        [StringLength(52)]
        public string CtaFinal { get; set; }

        public bool? TipoMovto { get; set; }

        [Required]
        [StringLength(52)]
        public string Importe { get; set; }

        [StringLength(52)]
        public string ImporteME { get; set; }

        [StringLength(100)]
        public string Referencia { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(52)]
        public string Diario { get; set; }

        [StringLength(52)]
        public string SegNeg { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public int? Base { get; set; }

        public double? ClaveBaseIVA { get; set; }

        public double? ClaveBaseISR { get; set; }
    }
}
