namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10043
    {
        public int? DiasAntiguedad { get; set; }

        public int? Enviado { get; set; }

        public int? Estado { get; set; }

        public DateTime? FechaEmision { get; set; }

        public DateTime? FechaFinalPago { get; set; }

        public DateTime? FechaInicialPago { get; set; }

        public DateTime? FechaInicioRelLaboral { get; set; }

        public DateTime? FechaPago { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDDocumento { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDDocumentoDSL { get; set; }

        [Key]
        public int IdDocumento { get; set; }

        public int? IdEmpleado { get; set; }

        public int? IdPeriodo { get; set; }

        public double? NumDiasPagados { get; set; }

        public double? SBC { get; set; }

        public DateTime? TimeStamp { get; set; }

        public int? TipoDocumento { get; set; }

        [Required]
        [StringLength(60)]
        public string UUID { get; set; }
    }
}