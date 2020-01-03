namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10001
    {
        [Key]
        public int idempleado { get; set; }

        public int? iddepartamento { get; set; }

        public int? idpuesto { get; set; }

        public int? idtipoperiodo { get; set; }

        public int? idturno { get; set; }

        [StringLength(30)]
        public string codigoempleado { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        [Column(TypeName = "image")]
        public byte[] fotografia { get; set; }

        [StringLength(40)]
        public string apellidopaterno { get; set; }

        [StringLength(40)]
        public string apellidomaterno { get; set; }

        [StringLength(120)]
        public string nombrelargo { get; set; }

        public DateTime? fechanacimiento { get; set; }

        [StringLength(40)]
        public string lugarnacimiento { get; set; }

        [StringLength(1)]
        public string estadocivil { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        [StringLength(6)]
        public string curpi { get; set; }

        [StringLength(8)]
        public string curpf { get; set; }

        [StringLength(15)]
        public string numerosegurosocial { get; set; }

        public int? umf { get; set; }

        [StringLength(4)]
        public string rfc { get; set; }

        [StringLength(4)]
        public string homoclave { get; set; }

        [StringLength(20)]
        public string cuentapagoelectronico { get; set; }

        [StringLength(50)]
        public string sucursalpagoelectronico { get; set; }

        [StringLength(3)]
        public string bancopagoelectronico { get; set; }

        [StringLength(1)]
        public string estadoempleado { get; set; }

        public double? sueldodiario { get; set; }

        public DateTime? fechasueldodiario { get; set; }

        public double? sueldovariable { get; set; }

        public DateTime? fechasueldovariable { get; set; }

        public double? sueldopromedio { get; set; }

        public DateTime? fechasueldopromedio { get; set; }

        public double? sueldointegrado { get; set; }

        public DateTime? fechasueldointegrado { get; set; }

        public bool calculado { get; set; }

        public bool afectado { get; set; }

        public bool calculadoextraordinario { get; set; }

        public bool? afectadoextraordinario { get; set; }

        public bool interfazcheqpaqw { get; set; }

        public bool modificacionneto { get; set; }

        public DateTime? fechaalta { get; set; }

        [StringLength(31)]
        public string cuentacw { get; set; }

        [StringLength(2)]
        public string tipocontrato { get; set; }

        [StringLength(1)]
        public string basecotizacionimss { get; set; }

        [StringLength(1)]
        public string tipoempleado { get; set; }

        [StringLength(1)]
        public string basepago { get; set; }

        [StringLength(3)]
        public string formapago { get; set; }

        [StringLength(1)]
        public string zonasalario { get; set; }

        public bool calculoptu { get; set; }

        public bool calculoaguinaldo { get; set; }

        public bool modificacionsalarioimss { get; set; }

        public bool altaimss { get; set; }

        public bool bajaimss { get; set; }

        public bool cambiocotizacionimss { get; set; }

        [Column(TypeName = "text")]
        public string expediente { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        public int? codigopostal { get; set; }

        [StringLength(60)]
        public string direccion { get; set; }

        [StringLength(60)]
        public string poblacion { get; set; }

        [StringLength(3)]
        public string estado { get; set; }

        [StringLength(60)]
        public string nombrepadre { get; set; }

        [StringLength(60)]
        public string nombremadre { get; set; }

        [StringLength(50)]
        public string numeroafore { get; set; }

        public DateTime? fechabaja { get; set; }

        [StringLength(60)]
        public string causabaja { get; set; }

        public double? sueldobaseliquidacion { get; set; }

        [StringLength(40)]
        public string campoextra1 { get; set; }

        [StringLength(40)]
        public string campoextra2 { get; set; }

        [StringLength(40)]
        public string campoextra3 { get; set; }

        public DateTime? fechareingreso { get; set; }

        public double? ajustealneto { get; set; }

        public DateTime? timestamp { get; set; }

        public int? cidregistropatronal { get; set; }

        public double? ccampoextranumerico1 { get; set; }

        public double? ccampoextranumerico2 { get; set; }

        public double? ccampoextranumerico3 { get; set; }

        public double? ccampoextranumerico4 { get; set; }

        public double? ccampoextranumerico5 { get; set; }

        [StringLength(4)]
        public string cestadoempleadoperiodo { get; set; }

        public DateTime? cfechasueldomixto { get; set; }

        public double? csueldomixto { get; set; }

        [StringLength(20)]
        public string NumeroFonacot { get; set; }

        [StringLength(60)]
        public string CorreoElectronico { get; set; }

        [StringLength(2)]
        public string TipoRegimen { get; set; }

        [StringLength(30)]
        public string ClabeInterbancaria { get; set; }

        [Required]
        [StringLength(2)]
        public string EntidadFederativa { get; set; }

        public bool Subcontratacion { get; set; }

        public bool ExtranjeroSinCURP { get; set; }

        public int TipoPrestacion { get; set; }

        public double DiasVacTomadasAntesdeAlta { get; set; }

        public double DiasPrimaVacTomadasAntesdeAlta { get; set; }
    }
}
