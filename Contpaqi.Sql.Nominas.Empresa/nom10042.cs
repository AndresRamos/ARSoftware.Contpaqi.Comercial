namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10042
    {
        [Key]
        public int IdMovtoCredito { get; set; }

        public int IdTarjetaCredito { get; set; }

        public int IdEmpleado { get; set; }

        public int IdPeriodo { get; set; }

        public int IdConcepto { get; set; }

        public double? Importe { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
