namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class IngresosNoDepositados
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

        public bool? EsDepositado { get; set; }

        public bool? EsAsociado { get; set; }

        [StringLength(20)]
        public string UsuAutorizaPresupuesto { get; set; }

        public int? PosibilidadPago { get; set; }

        public bool? EsProyectado { get; set; }

        public int? Origen { get; set; }

        public int? IdChequeOrigen { get; set; }

        public int? IdCuentaCheques { get; set; }

        public int? IdDeposito { get; set; }

        public double? TipoCambioDeposito { get; set; }

        public int? IdDocumento { get; set; }

        public bool? EsAnticipo { get; set; }

        public bool? EsTraspasado { get; set; }

        [StringLength(20)]
        public string UsuarioCrea { get; set; }

        [StringLength(20)]
        public string UsuarioModifica { get; set; }

        public bool? tieneCFD { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }
    }
}