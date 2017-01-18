namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProcesosReexpresion")]
    public partial class ProcesosReexpresion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Ejercicio { get; set; }

        public int Periodo { get; set; }

        public int TipoInventario { get; set; }

        public int IdCuenta { get; set; }

        public int? Rotacion { get; set; }

        public DateTime? FechaAportacion { get; set; }

        public int? IdINPC { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
