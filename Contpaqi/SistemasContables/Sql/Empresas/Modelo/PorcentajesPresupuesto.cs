namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PorcentajesPresupuesto")]
    public partial class PorcentajesPresupuesto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        public double? Porcentaje1 { get; set; }

        public double? Porcentaje2 { get; set; }

        public double? Porcentaje3 { get; set; }

        public double? Porcentaje4 { get; set; }

        public double? Porcentaje5 { get; set; }

        public double? Porcentaje6 { get; set; }

        public double? Porcentaje7 { get; set; }

        public double? Porcentaje8 { get; set; }

        public double? Porcentaje9 { get; set; }

        public double? Porcentaje10 { get; set; }

        public double? Porcentaje11 { get; set; }

        public double? Porcentaje12 { get; set; }

        public double? Porcentaje13 { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
