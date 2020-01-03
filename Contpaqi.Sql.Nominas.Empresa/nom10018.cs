namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10018
    {
        [Key]
        public int idtarjetaincapacidad { get; set; }

        public int? idtipoincidencia { get; set; }

        public int? idempleado { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        public int? diasautorizados { get; set; }

        public DateTime? fechainicio { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        [StringLength(1)]
        public string incapacidadinicial { get; set; }

        [StringLength(1)]
        public string ramoseguro { get; set; }

        [StringLength(1)]
        public string tiporiesgo { get; set; }

        public int? numerocaso { get; set; }

        public bool fincaso { get; set; }

        public double? porcentajeincapacidad { get; set; }

        public bool controlmaternidad { get; set; }

        [StringLength(40)]
        public string nombremedico { get; set; }

        [StringLength(40)]
        public string matriculamedico { get; set; }

        [StringLength(1)]
        public string circunstancia { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(1)]
        public string controlincapacidad { get; set; }

        [StringLength(1)]
        public string secuelaconsecuencia { get; set; }
    }
}
