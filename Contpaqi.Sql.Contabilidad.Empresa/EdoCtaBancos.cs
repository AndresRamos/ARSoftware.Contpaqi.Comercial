namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EdoCtaBancos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Numero { get; set; }

        public int IdCuentaCheques { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public bool EstadoConciliacion { get; set; }

        public double? SaldoInicial { get; set; }

        public double? SaldoFinal { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
