namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class NOM10000
    {
        public bool AfectarPeriodosAnteriores { get; set; }

        public bool AfectarPeriodosFuturos { get; set; }

        [StringLength(11)]
        public string ApartadoPostal { get; set; }

        [StringLength(40)]
        public string ApMaternoRepresentante { get; set; }

        [StringLength(40)]
        public string ApPaternoRepresentante { get; set; }

        [StringLength(5)]
        public string CodigoPostal { get; set; }

        public bool Contratista { get; set; }

        [StringLength(31)]
        public string CuentaCWGlobal { get; set; }

        [Required]
        [StringLength(18)]
        public string CURP { get; set; }

        [StringLength(60)]
        public string Direccion { get; set; }

        public int? Ejercicio { get; set; }

        public int? EmitirRecibo { get; set; }

        [StringLength(50)]
        public string EstructuraCuentaCW { get; set; }

        public double? FactorNoDeducExento { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        public DateTime? FechaConstitucion { get; set; }

        public DateTime? FechaInicioHistoria { get; set; }

        [StringLength(255)]
        public string FormatoSobreRecibo { get; set; }

        [Required]
        [StringLength(100)]
        public string FormatoSobreReciboCFDI { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDDSL { get; set; }

        [Required]
        [StringLength(40)]
        public string GUIDEmpresa { get; set; }

        [StringLength(4)]
        public string Homoclave { get; set; }

        public int? IDCptoAguinaldo { get; set; }

        public int? IDCptoAjuste { get; set; }

        public int? IDCptoIndem20 { get; set; }

        public int? IDCptoIndem90 { get; set; }

        public int? IDCptoPrimaAntig { get; set; }

        public int? IDCptoPrimaVac { get; set; }

        public int? IDCptoPrimaVacRep { get; set; }

        public int? IDCptoPTU { get; set; }

        public int? IDCptoSueldo { get; set; }

        public int? IDCptoVacaciones { get; set; }

        public int? IDCptoVacRep { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDEmpresa { get; set; }

        public int? IDEmpresaContpaqW { get; set; }

        [StringLength(40)]
        public string Localidad { get; set; }

        public int? LongitudCuentaDepto { get; set; }

        public int? LongitudCuentaEmpleado { get; set; }

        [StringLength(30)]
        public string MascarillaCodigo { get; set; }

        public bool MostrarAgenda { get; set; }

        [StringLength(15)]
        public string NombreCorto { get; set; }

        [Key]
        [StringLength(254)]
        public string NombreEmpresa { get; set; }

        [StringLength(40)]
        public string NombreRepresentante { get; set; }

        public int? NumeroDecimales { get; set; }

        public int? OrigenDSL { get; set; }

        [Required]
        [StringLength(2)]
        public string OrigenRecursos { get; set; }

        public double? PorcentajeSubsidio { get; set; }

        public int? PosicionCuentaDepto { get; set; }

        public int? PosicionCuentaEmpleado { get; set; }

        [StringLength(253)]
        public string RegimenFiscal { get; set; }

        [StringLength(50)]
        public string RegistroCamara { get; set; }

        [StringLength(50)]
        public string RegistroComisionMixta { get; set; }

        [StringLength(20)]
        public string RegistroFonacot { get; set; }

        [StringLength(20)]
        public string RegistroIMSS { get; set; }

        [StringLength(20)]
        public string RegistroInfonavit { get; set; }

        [StringLength(50)]
        public string RegistroSSA { get; set; }

        [StringLength(4)]
        public string RFC { get; set; }

        [StringLength(255)]
        public string RutaCheqpaqW { get; set; }

        [StringLength(255)]
        public string RutaContpaqW { get; set; }

        [StringLength(255)]
        public string RutaEmpresa { get; set; }

        [StringLength(255)]
        public string RutaRespaldo { get; set; }

        [StringLength(20)]
        public string Telefono1 { get; set; }

        [StringLength(20)]
        public string Telefono2 { get; set; }

        [StringLength(20)]
        public string Telefono3 { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(10)]
        public string TipoCodigoEmpleado { get; set; }

        [Required]
        [StringLength(5)]
        public string vConfigComplemento { get; set; }

        [Required]
        [StringLength(5)]
        public string vConfigComprobante { get; set; }

        [Required]
        [StringLength(5)]
        public string vUltTimbreComplemento { get; set; }

        [Required]
        [StringLength(5)]
        public string vUltTimbreComprobante { get; set; }

        [StringLength(1)]
        public string ZonaSalarioGeneral { get; set; }
    }
}