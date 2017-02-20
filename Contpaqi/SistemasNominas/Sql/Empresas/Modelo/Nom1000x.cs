namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Nom1000x
    {
        public int? idconcepto { get; set; }

        public int? idempleado { get; set; }

        public int? idmovtopdo { get; set; }

        public int? idmovtopermanente { get; set; }

        public int? idperiodo { get; set; }

        public double? importe1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool importe1reportado { get; set; }

        public double? importe2 { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool importe2reportado { get; set; }

        public double? importe3 { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool importe3reportado { get; set; }

        public double? importe4 { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool importe4reportado { get; set; }

        public double? importetotal { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool importetotalreportado { get; set; }

        public DateTime? timestam_ { get; set; }

        public double? valor { get; set; }
    }
}