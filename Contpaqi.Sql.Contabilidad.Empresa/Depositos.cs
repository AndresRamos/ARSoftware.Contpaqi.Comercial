namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Depositos
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

        public int IdCuentaCheques { get; set; }

        public int NatBancaria { get; set; }

        public int Naturaleza { get; set; }

        public double? Total { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(1000)]
        public string Concepto { get; set; }

        public bool? EsConciliado { get; set; }

        public int? IdMovEdoCta { get; set; }

        public int? EjercicioPol { get; set; }

        public int? PeriodoPol { get; set; }

        public int? TipoPol { get; set; }

        public int? NumPol { get; set; }

        [StringLength(1)]
        public string FormaDeposito { get; set; }

        public int? IdPoliza { get; set; }

        public int? Origen { get; set; }

        public int? IdDocumento { get; set; }

        public bool? PolizaAgrupada { get; set; }

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
