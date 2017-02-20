namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10017
    {
        [StringLength(40)]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public DateTime? fechainiciotarjeta { get; set; }

        public DateTime? fecharegistro { get; set; }

        public int? idconcepto { get; set; }

        public int? idempleado { get; set; }

        [Key]
        public int idmovtopermanente { get; set; }

        public double? montoacumulado { get; set; }

        public double? montoacumuladoejeant { get; set; }

        public double? montolimite { get; set; }

        [StringLength(40)]
        public string numerocontrol { get; set; }

        public int? numerofiltro { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public double? valor { get; set; }

        public int? vecesaplicado { get; set; }

        public int? vecesaplicar { get; set; }
    }
}