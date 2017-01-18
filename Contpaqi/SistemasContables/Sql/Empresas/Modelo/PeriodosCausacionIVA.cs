namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PeriodosCausacionIVA")]
    public partial class PeriodosCausacionIVA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int? IdPoliza { get; set; }

        public int IdMovimiento { get; set; }

        public int? EjercicioAsignado { get; set; }

        public int? PeriodoAsignado { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
