namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PagosProvisionalISR")]
    public partial class PagosProvisionalISR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Ejercicio { get; set; }

        public int Periodo { get; set; }

        public double? IngresosAcum { get; set; }

        public double? IngresosPeriodo { get; set; }

        public double? OtrosIngresos { get; set; }

        public double? NotasCredito { get; set; }

        public double? OtrosConceptos { get; set; }

        public double? IngresosTotales { get; set; }

        public double? CoeficienteUtil { get; set; }

        public double? UtilidadFiscal { get; set; }

        public double? AcumPerdidas { get; set; }

        public double? PerdidasFiscales { get; set; }

        public double? AcumuladoPTU { get; set; }

        public double? PTUPagado { get; set; }

        public double? BaseGravPagoProv { get; set; }

        public double? TasaImpuestos { get; set; }

        public double? ISRCausado { get; set; }

        public double? PagosEfectuados { get; set; }

        public double? AcumuladoRetenciones { get; set; }

        public double? Retenciones { get; set; }

        public double? ImpuestoACargoISR { get; set; }

        public double? PagosIndebidos { get; set; }

        public double? ImpuestoEfectPagado { get; set; }

        public double? Diferencia { get; set; }
    }
}
