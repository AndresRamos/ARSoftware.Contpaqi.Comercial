namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientosPlantillaAsiento")]
    public partial class MovimientosPlantillaAsiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int NumeroMovto { get; set; }

        public int IdPlantillaAsiento { get; set; }

        public int? TipoMovto { get; set; }

        public int? Referencia { get; set; }

        [StringLength(30)]
        public string TextoReferencia { get; set; }

        public int? Concepto { get; set; }

        [StringLength(100)]
        public string TextoConcepto { get; set; }

        public int? IdSegmentoNegocio { get; set; }

        public bool? ConcentrarMovimientos { get; set; }

        [StringLength(100)]
        public string FormulaCuenta { get; set; }

        [StringLength(500)]
        public string FormulaImporte { get; set; }

        [StringLength(500)]
        public string FormulaImporteME { get; set; }

        public int? IdDiario { get; set; }

        public int? OpcionSegmento { get; set; }
    }
}
