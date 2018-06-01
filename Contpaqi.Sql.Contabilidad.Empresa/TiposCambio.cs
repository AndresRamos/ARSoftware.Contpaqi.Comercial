namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposCambio")]
    public partial class TiposCambio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Moneda { get; set; }

        public DateTime Fecha { get; set; }

        public double? TipoCambio { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int Tipo { get; set; }
    }
}
