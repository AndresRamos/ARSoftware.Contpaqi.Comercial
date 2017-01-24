namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MovimientosPoliza")]
    public partial class MovimientosPoliza
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdPoliza { get; set; }

        public int Ejercicio { get; set; }

        public int Periodo { get; set; }

        public int TipoPol { get; set; }

        public int Folio { get; set; }

        public int NumMovto { get; set; }

        public int IdCuenta { get; set; }

        public bool? TipoMovto { get; set; }

        public double? Importe { get; set; }

        public double? ImporteME { get; set; }

        [StringLength(30)]
        public string Referencia { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        public int? IdDiario { get; set; }

        public DateTime Fecha { get; set; }

        public int? IdSegNeg { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(36)]
        public string Guid { get; set; }
    }
}