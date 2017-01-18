namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Afectaciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int NumTransac { get; set; }

        public int IdMovimiento { get; set; }

        public int Consec { get; set; }

        public int IdEmpresa { get; set; }

        public int? Ejercicio { get; set; }

        public int? Periodo { get; set; }

        public int? EjeActual { get; set; }

        public int IdCuenta { get; set; }

        public int IdSegNeg { get; set; }

        public DateTime Fecha { get; set; }

        public bool TipoMovto { get; set; }

        public double? Importe { get; set; }

        public double? ImporteME { get; set; }

        public bool? AfectaEjeAnt { get; set; }

        public int Estado { get; set; }

        public int? MotivoError { get; set; }

        public int? IdPoliza { get; set; }

        public int? IdUsuario { get; set; }
    }
}
