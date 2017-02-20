namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10014
    {
        [StringLength(100)]
        public string diasdescanso { get; set; }

        public double? diasprimavacacional { get; set; }

        public int? diasvacaciones { get; set; }

        public int? ejercicio { get; set; }

        public DateTime? fechafin { get; set; }

        public DateTime? fechainicio { get; set; }

        public DateTime? fechapago { get; set; }

        public int? idempleado { get; set; }

        [Key]
        public int idtcontrolvacaciones { get; set; }

        public DateTime? timestamp { get; set; }
    }
}