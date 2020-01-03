namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10000
    {
        public int? idcptoprimavac { get; set; }

        public int? idcptoaguinaldo { get; set; }

        public int? idcptoptu { get; set; }

        public int? idcptovacaciones { get; set; }

        [StringLength(15)]
        public string nombrecorto { get; set; }

        [StringLength(255)]
        public string rutarespaldo { get; set; }

        [StringLength(255)]
        public string rutacontpaqw { get; set; }

        [StringLength(255)]
        public string rutacheqpaqw { get; set; }

        public int? idempresacontpaqw { get; set; }

        [StringLength(60)]
        public string direccion { get; set; }

        [StringLength(20)]
        public string telefono1 { get; set; }

        [StringLength(20)]
        public string telefono2 { get; set; }

        [StringLength(20)]
        public string telefono3 { get; set; }

        [StringLength(20)]
        public string fax { get; set; }

        [StringLength(20)]
        public string registroimss { get; set; }

        [StringLength(50)]
        public string registrocamara { get; set; }

        [StringLength(4)]
        public string rfc { get; set; }

        [StringLength(4)]
        public string homoclave { get; set; }

        [StringLength(20)]
        public string registroinfonavit { get; set; }

        [StringLength(20)]
        public string registrofonacot { get; set; }

        [StringLength(50)]
        public string registrocomisionmixta { get; set; }

        [StringLength(50)]
        public string registrossa { get; set; }

        [StringLength(1)]
        public string zonasalariogeneral { get; set; }

        public DateTime? fechainiciohistoria { get; set; }

        public DateTime? fechaconstitucion { get; set; }

        public int? ejercicio { get; set; }

        public double? porcentajesubsidio { get; set; }

        [StringLength(31)]
        public string cuentacwglobal { get; set; }

        [StringLength(50)]
        public string estructuracuentacw { get; set; }

        [StringLength(255)]
        public string formatosobrerecibo { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool afectarperiodosanteriores { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool afectarperiodosfuturos { get; set; }

        public int? posicioncuentaempleado { get; set; }

        public int? longitudcuentaempleado { get; set; }

        public int? posicioncuentadepto { get; set; }

        public int? longitudcuentadepto { get; set; }

        [StringLength(40)]
        public string localidad { get; set; }

        [StringLength(40)]
        public string nombrerepresentante { get; set; }

        [StringLength(40)]
        public string appaternorepresentante { get; set; }

        [StringLength(40)]
        public string apmaternorepresentante { get; set; }

        [StringLength(5)]
        public string codigopostal { get; set; }

        [StringLength(11)]
        public string apartadopostal { get; set; }

        [StringLength(30)]
        public string mascarillacodigo { get; set; }

        public int? numerodecimales { get; set; }

        [StringLength(1)]
        public string tipocodigoempleado { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool mostraragenda { get; set; }

        public DateTime? timestamp { get; set; }

        public int? idcptoajuste { get; set; }

        public int? idcptoindem20 { get; set; }

        public int? idcptoindem90 { get; set; }

        public int? idcptoprimaantig { get; set; }

        public int? idcptoprimavacrep { get; set; }

        public int? idcptosueldo { get; set; }

        public int? idcptovacrep { get; set; }

        public double? FactorNoDeducExento { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string GUIDEmpresa { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string GUIDDSL { get; set; }

        public int? EmitirRecibo { get; set; }

        [StringLength(3)]
        public string RegimenFiscal { get; set; }

        public int? OrigenDSL { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string FormatoSobreReciboCFDI { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(18)]
        public string CURP { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(5)]
        public string vConfigComprobante { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(5)]
        public string vUltTimbreComprobante { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(5)]
        public string vConfigComplemento { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(5)]
        public string vUltTimbreComplemento { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string OrigenRecursos { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool contratista { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool DatosVigente { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string RelacionarCFDI { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(40)]
        public string GUIDEmpresaOrigen { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool SubsidioCausado { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool FiniquitoDividido { get; set; }
    }
}
