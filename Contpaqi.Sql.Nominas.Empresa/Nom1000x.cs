namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nom1000x
    {
        public int? idmovtopdo { get; set; }

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

        [Key]
        [Column(Order = 0)]
        public bool importetotalreportado { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool importe1reportado { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool importe2reportado { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool importe3reportado { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool importe4reportado { get; set; }

        public DateTime? timestam_ { get; set; }
    }
}
