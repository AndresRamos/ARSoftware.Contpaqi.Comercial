namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10043
    {
        [Key]
        public int IdDocumento { get; set; }

        public int? IdEmpleado { get; set; }

        public int? IdPeriodo { get; set; }

        public int? TipoDocumento { get; set; }

        public int? Estado { get; set; }

        public DateTime? FechaPago { get; set; }

        public DateTime? FechaEmision { get; set; }

        public double? NumDiasPagados { get; set; }

        public int? DiasAntiguedad { get; set; }

        [Required]
        [StringLength(60)]
        public string UUID { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDDocumentoDSL { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDDocumento { get; set; }

        public int? Enviado { get; set; }

        public DateTime? FechaInicialPago { get; set; }

        public DateTime? FechaFinalPago { get; set; }

        public DateTime? FechaInicioRelLaboral { get; set; }

        public double? SBC { get; set; }

        public DateTime? TimeStamp { get; set; }

        public double? NumAnosServicio { get; set; }

        public bool RelacionarCFDICancelado { get; set; }

        public bool HayRelacionCFDICancelado { get; set; }

        [Required]
        [StringLength(32)]
        public string Confirmacion { get; set; }

        [Required]
        [StringLength(1000)]
        public string URLCaptcha { get; set; }

        [Required]
        [StringLength(5)]
        public string vComplemento { get; set; }

        [Required]
        [StringLength(5)]
        public string vComprobante { get; set; }
    }
}
