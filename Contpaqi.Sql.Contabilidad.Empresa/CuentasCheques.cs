namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CuentasCheques
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        public int? IdBanco { get; set; }

        [StringLength(20)]
        public string CodigoMoneda { get; set; }

        public bool? UsarRefConciliacion { get; set; }

        public bool? UsaRango { get; set; }

        public bool? UsaNumeracionAut { get; set; }

        [StringLength(20)]
        public string FolioActual { get; set; }

        [StringLength(20)]
        public string FolioInicial { get; set; }

        [StringLength(20)]
        public string FolioFinal { get; set; }

        [StringLength(60)]
        public string Titular1 { get; set; }

        [StringLength(60)]
        public string Titular2 { get; set; }

        [StringLength(60)]
        public string Titular3 { get; set; }

        public DateTime? FechaUltConciliacion { get; set; }

        [StringLength(30)]
        public string CodigoCuenta { get; set; }

        [StringLength(30)]
        public string CodigoCtaComplementaria { get; set; }

        public int? IdSegNeg { get; set; }

        [StringLength(5)]
        public string NumSucursal { get; set; }

        [StringLength(60)]
        public string Sucursal { get; set; }

        [StringLength(60)]
        public string Ejecutivo { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(254)]
        public string FormatoCheque { get; set; }

        [StringLength(254)]
        public string FormatoDeposito { get; set; }

        [StringLength(254)]
        public string FormatoCargo { get; set; }

        [StringLength(254)]
        public string FormatoAbono { get; set; }

        [StringLength(254)]
        public string FormatoIngreso { get; set; }

        public int? IdDatoExtra { get; set; }

        public int? Referencia { get; set; }

        public int? Concepto { get; set; }

        public bool? UsaActTipoCambio { get; set; }

        public int? IdPlantillaEstadoCuenta { get; set; }

        public DateTime? FechaSaldoInicial { get; set; }

        public int? IdDiarioEgreso { get; set; }

        public int? IdDiarioIngreso { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialCheque { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialEgreso { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialIngreso { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialIngresoND { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialIngresoCFD { get; set; }

        [StringLength(30)]
        public string CodigoConceptoComercialIngresoNDCFD { get; set; }

        public bool? permitirCambiarConceptoComercial { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque1 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque2 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque3 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque4 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque5 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque6 { get; set; }

        [StringLength(30)]
        public string SegContCuentaCheque7 { get; set; }
    }
}
