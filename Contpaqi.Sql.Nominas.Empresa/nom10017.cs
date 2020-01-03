namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10017
    {
        [Key]
        public int idmovtopermanente { get; set; }

        public int? idempleado { get; set; }

        public int? idconcepto { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public double? valor { get; set; }

        public int? vecesaplicar { get; set; }

        public int? vecesaplicado { get; set; }

        public double? montolimite { get; set; }

        public double? montoacumulado { get; set; }

        public double? montoacumuladoejeant { get; set; }

        public DateTime? fecharegistro { get; set; }

        [StringLength(40)]
        public string numerocontrol { get; set; }

        public bool estado { get; set; }

        public DateTime? timestamp { get; set; }

        public int? numerofiltro { get; set; }

        public DateTime? fechainiciotarjeta { get; set; }
    }
}
