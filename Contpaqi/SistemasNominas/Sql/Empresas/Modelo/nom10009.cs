namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10009
    {
        public DateTime? fecha { get; set; }

        public int? idempleado { get; set; }

        [Key]
        public int idmovtodyh { get; set; }

        public int? idperiodo { get; set; }

        public int? idtarjetaincapacidad { get; set; }

        public int? idtcontrolvacaciones { get; set; }

        public int? idtipoincidencia { get; set; }

        public DateTime? timestamp { get; set; }

        public double? valor { get; set; }
    }
}