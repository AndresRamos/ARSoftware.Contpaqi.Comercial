namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10039
    {
        public bool AplicaCalculo { get; set; }

        public double? Articulo177 { get; set; }

        public double? BaseGAcumulada { get; set; }

        public double? BaseGProyectada { get; set; }

        public int Causa { get; set; }

        [StringLength(1)]
        public string ClaveABR { get; set; }

        public double? CompensadoRetenido { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ejercicio { get; set; }

        public DateTime? FechaABR { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }

        public double? ImpuestoAnual { get; set; }

        public double? ImpuestoFinal { get; set; }

        public bool ImpuestoFinalReportado { get; set; }

        public double? ImpuestoRetenido { get; set; }

        public double? IngresoAnual { get; set; }

        public double? SubsidioCorrespondiente { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}