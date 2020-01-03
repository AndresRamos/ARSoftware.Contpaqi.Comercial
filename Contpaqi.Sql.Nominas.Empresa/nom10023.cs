namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10023
    {
        [Key]
        public int idtipoperiodo { get; set; }

        [StringLength(40)]
        public string nombretipoperiodo { get; set; }

        public int? diasdelperiodo { get; set; }

        public double? diasdepago { get; set; }

        public int? periodotrabajo { get; set; }

        public bool modificarhistoria { get; set; }

        public bool ajustarperiodoscalendario { get; set; }

        public int? numeroseptimos { get; set; }

        [StringLength(30)]
        public string posicionseptimos { get; set; }

        public int? posicionpagonomina { get; set; }

        public DateTime? fechainicioejercicio { get; set; }

        public int? ejercicio { get; set; }

        public DateTime? timestamp { get; set; }

        public int? ccalculomescalendario { get; set; }

        [Required]
        [StringLength(3)]
        public string PeriodicidadPago { get; set; }
    }
}
