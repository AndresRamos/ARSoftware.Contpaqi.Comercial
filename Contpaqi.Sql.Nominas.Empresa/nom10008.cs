namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10008
    {
        [Key]
        public int idmovtopdo { get; set; }

        public int? idperiodo { get; set; }

        public int? idempleado { get; set; }

        public int? idconcepto { get; set; }

        public int? idmovtopermanente { get; set; }

        public double? importetotal { get; set; }

        public double? valor { get; set; }

        public double? importe1 { get; set; }

        public double? importe2 { get; set; }

        public double? importe3 { get; set; }

        public double? importe4 { get; set; }

        public bool importetotalreportado { get; set; }

        public bool importe1reportado { get; set; }

        public bool importe2reportado { get; set; }

        public bool importe3reportado { get; set; }

        public bool importe4reportado { get; set; }

        public DateTime? timestamp { get; set; }
    }
}
