namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        public int? TipoOperacion { get; set; }

        public int? IdCuenta { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public bool? TasaIVA15 { get; set; }

        public bool? TasaIVA10 { get; set; }

        public bool? TasaIVA0 { get; set; }

        public bool? TasaIVAExento { get; set; }

        public bool? TasaIVAOtra1 { get; set; }

        public bool? TasaIVAOtra2 { get; set; }

        public double? TasaOtra1 { get; set; }

        public double? TasaOtra2 { get; set; }

        public int? TasaAsumida { get; set; }

        public double? RetencionIVA { get; set; }

        public double? RetencionISR { get; set; }

        public int? TipoTercero { get; set; }

        [StringLength(50)]
        public string IdFiscal { get; set; }

        [StringLength(200)]
        public string NomExtranjero { get; set; }

        [StringLength(3)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Nacionalidad { get; set; }

        public int? IdConceptoIETU { get; set; }

        [StringLength(40)]
        public string CodigoPersona { get; set; }

        [StringLength(30)]
        public string CodigoCuenta { get; set; }

        public bool? EsParaAbonoCta { get; set; }

        [StringLength(30)]
        public string CodigoCtaComplementaria { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public int? IdSegNeg { get; set; }

        public bool? TasaIVA16 { get; set; }

        public bool? TasaIVA11 { get; set; }

        [StringLength(10)]
        public string ClaveBanco { get; set; }

        [StringLength(10)]
        public string Sucursal { get; set; }

        [StringLength(50)]
        public string CuentaClabe { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(30)]
        public string CodigoCtaGastos { get; set; }

        [StringLength(30)]
        public string CodigoCtaGastosComplementaria { get; set; }

        public bool? TasaIVA8 { get; set; }

        [StringLength(30)]
        public string SegContProveedor1 { get; set; }

        [StringLength(30)]
        public string SegContProveedor2 { get; set; }

        [StringLength(30)]
        public string SegContProveedor3 { get; set; }

        [StringLength(30)]
        public string SegContProveedor4 { get; set; }

        [StringLength(30)]
        public string SegContProveedor5 { get; set; }

        [StringLength(30)]
        public string SegContProveedor6 { get; set; }

        [StringLength(30)]
        public string SegContProveedor7 { get; set; }
    }
}
