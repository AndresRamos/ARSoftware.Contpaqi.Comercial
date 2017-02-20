namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10002
    {
        public bool afectado { get; set; }

        public bool calculado { get; set; }

        public bool cfinbimestreimss { get; set; }

        public bool ciniciobimestreimss { get; set; }

        public double? diasdepago { get; set; }

        public int? ejercicio { get; set; }

        public DateTime? fechafin { get; set; }

        public DateTime? fechainicio { get; set; }

        public bool finejercicio { get; set; }

        public bool finmes { get; set; }

        [Key]
        public int idperiodo { get; set; }

        public int? idtipoperiodo { get; set; }

        public bool inicioejercicio { get; set; }

        public bool iniciomes { get; set; }

        public bool interfazcheqpaqw { get; set; }

        public int? mes { get; set; }

        public bool modificacionneto { get; set; }

        public int? numeroperiodo { get; set; }

        public int? septimos { get; set; }

        public DateTime? timestamp { get; set; }
    }
}