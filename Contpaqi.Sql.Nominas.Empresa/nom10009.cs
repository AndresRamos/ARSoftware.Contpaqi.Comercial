namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10009
    {
        [Key]
        public int idmovtodyh { get; set; }

        public int? idperiodo { get; set; }

        public int? idempleado { get; set; }

        public int? idtipoincidencia { get; set; }

        public int? idtarjetaincapacidad { get; set; }

        public int? idtcontrolvacaciones { get; set; }

        public DateTime? fecha { get; set; }

        public double? valor { get; set; }

        public DateTime? timestamp { get; set; }
    }
}
