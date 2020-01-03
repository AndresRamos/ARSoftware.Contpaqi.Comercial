namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10014
    {
        [Key]
        public int idtcontrolvacaciones { get; set; }

        public int? idempleado { get; set; }

        public int? ejercicio { get; set; }

        public int? diasvacaciones { get; set; }

        public double? diasprimavacacional { get; set; }

        public DateTime? fechainicio { get; set; }

        public DateTime? fechafin { get; set; }

        [StringLength(100)]
        public string diasdescanso { get; set; }

        public DateTime? timestamp { get; set; }

        public DateTime? fechapago { get; set; }
    }
}
