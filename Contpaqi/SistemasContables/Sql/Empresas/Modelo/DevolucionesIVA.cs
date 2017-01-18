namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DevolucionesIVA")]
    public partial class DevolucionesIVA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdPoliza { get; set; }

        public int NumDev { get; set; }

        public int IdProveedor { get; set; }

        public double? ImpTotal { get; set; }

        public double? PorIVA { get; set; }

        public double? ImpBase { get; set; }

        public double? ImpIVA { get; set; }

        public bool? CausaIVA { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public bool? ExentoIVA { get; set; }

        public int? IdDocto2 { get; set; }

        [StringLength(15)]
        public string Serie { get; set; }

        public int? Folio { get; set; }

        [StringLength(30)]
        public string Referencia { get; set; }

        public double? OtrosImptos { get; set; }

        public double? ImpSinRet { get; set; }

        public double? IVARetenido { get; set; }

        public double? ISRRetenido { get; set; }

        public double? GranTotal { get; set; }

        public int? EjercicioAsignado { get; set; }

        public int? PeriodoAsignado { get; set; }

        public int? IdCuenta { get; set; }

        public double? IVAPagNoAcred { get; set; }

        public double? IETUDeducible { get; set; }

        public bool? IETUModificado { get; set; }

        public double? IETUAcreditable { get; set; }

        public int? IdConceptoIETU { get; set; }

        [StringLength(36)]
        public string UUID { get; set; }
    }
}
