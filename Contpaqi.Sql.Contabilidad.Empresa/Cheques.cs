namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cheques
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdDocumentoDe { get; set; }

        [Required]
        [StringLength(30)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public int? Ejercicio { get; set; }

        public int? Periodo { get; set; }

        public DateTime FechaAplicacion { get; set; }

        public int? EjercicioAp { get; set; }

        public int? PeriodoAp { get; set; }

        [StringLength(40)]
        public string CodigoPersona { get; set; }

        [StringLength(200)]
        public string BeneficiarioPagador { get; set; }

        public int IdCuentaCheques { get; set; }

        public int NatBancaria { get; set; }

        public int Naturaleza { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoMoneda { get; set; }

        [StringLength(5)]
        public string CodigoMonedaTipoCambio { get; set; }

        public double? TipoCambio { get; set; }

        public double? Total { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(1000)]
        public string Concepto { get; set; }

        public bool? EsImpreso { get; set; }

        public bool? EsCancelado { get; set; }

        public bool? EsAutorizado { get; set; }

        public bool? EsConciliado { get; set; }

        public bool? EsDevuelto { get; set; }

        public bool? EsAsociado { get; set; }

        public bool? EsParaAbonoCta { get; set; }

        [StringLength(20)]
        public string UsuAutoriza { get; set; }

        [StringLength(20)]
        public string UsuAutorizaPresupuesto { get; set; }

        public int? IdMovEdoCta { get; set; }

        [StringLength(20)]
        public string Prioridad { get; set; }

        public int? IdIngresoNoDepDestino { get; set; }

        public int? EjercicioPol { get; set; }

        public int? PeriodoPol { get; set; }

        public int? TipoPol { get; set; }

        public int? NumPol { get; set; }

        public int? PosibilidadPago { get; set; }

        public bool? EsProyectado { get; set; }

        public int? IdPoliza { get; set; }

        public int? Origen { get; set; }

        public int IdDocumento { get; set; }

        public int? EjercicioPolOrigen { get; set; }

        public int? PeriodoPolOrigen { get; set; }

        public int? TipoPolOrigen { get; set; }

        public int? NumPolOrigen { get; set; }

        public int? IdPolizaOrigen { get; set; }

        public bool? EsAnticipo { get; set; }

        public bool? EsTraspasado { get; set; }

        public bool? PolizaAgrupada { get; set; }

        [StringLength(20)]
        public string UsuarioCrea { get; set; }

        [StringLength(20)]
        public string UsuarioModifica { get; set; }

        public bool? tieneCFD { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        [StringLength(50)]
        public string CuentaDestino { get; set; }

        public int? BancoDestino { get; set; }

        [StringLength(2)]
        public string OtroMetodoDePago { get; set; }

        [StringLength(36)]
        public string UUIDRep { get; set; }

        public int? NodoPago { get; set; }
    }
}
