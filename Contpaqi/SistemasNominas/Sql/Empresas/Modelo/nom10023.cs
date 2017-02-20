namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class nom10023
    {
        public bool ajustarperiodoscalendario { get; set; }

        public int? ccalculomescalendario { get; set; }

        public int? diasdelperiodo { get; set; }

        public double? diasdepago { get; set; }

        public int? ejercicio { get; set; }

        public DateTime? fechainicioejercicio { get; set; }

        [Key]
        public int idtipoperiodo { get; set; }

        public bool modificarhistoria { get; set; }

        [StringLength(40)]
        public string nombretipoperiodo { get; set; }

        public int? numeroseptimos { get; set; }

        public int? periodotrabajo { get; set; }

        public int? posicionpagonomina { get; set; }

        [StringLength(30)]
        public string posicionseptimos { get; set; }

        public DateTime? timestamp { get; set; }
    }
}