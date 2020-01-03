namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10002
    {
        [Key]
        public int idperiodo { get; set; }

        public int? idtipoperiodo { get; set; }

        public int? numeroperiodo { get; set; }

        public int? ejercicio { get; set; }

        public int? mes { get; set; }

        public double? diasdepago { get; set; }

        public int? septimos { get; set; }

        public bool interfazcheqpaqw { get; set; }

        public bool modificacionneto { get; set; }

        public bool calculado { get; set; }

        public bool afectado { get; set; }

        public DateTime? fechainicio { get; set; }

        public DateTime? fechafin { get; set; }

        public bool inicioejercicio { get; set; }

        public bool iniciomes { get; set; }

        public bool finmes { get; set; }

        public bool finejercicio { get; set; }

        public DateTime? timestamp { get; set; }

        public bool cfinbimestreimss { get; set; }

        public bool ciniciobimestreimss { get; set; }
    }
}
