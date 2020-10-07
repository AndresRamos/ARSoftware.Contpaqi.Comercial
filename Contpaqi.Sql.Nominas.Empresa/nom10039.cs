namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10039
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ejercicio { get; set; }

        public bool AplicaCalculo { get; set; }

        public int Causa { get; set; }

        public DateTime? FechaABR { get; set; }

        [StringLength(1)]
        public string ClaveABR { get; set; }

        public double? IngresoAnual { get; set; }

        public double? BaseGAcumulada { get; set; }

        public double? BaseGProyectada { get; set; }

        public double? Articulo177 { get; set; }

        public double? SubsidioCorrespondiente { get; set; }

        public double? ImpuestoAnual { get; set; }

        public double? ImpuestoRetenido { get; set; }

        public double? CompensadoRetenido { get; set; }

        public double? ImpuestoFinal { get; set; }

        public bool ImpuestoFinalReportado { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
