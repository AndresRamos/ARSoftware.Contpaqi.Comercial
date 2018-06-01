namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PeriodosCausacionIVA")]
    public partial class PeriodosCausacionIVA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int? IdPoliza { get; set; }

        public int IdMovimiento { get; set; }

        public int? EjercicioAsignado { get; set; }

        public int? PeriodoAsignado { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
