namespace Contpaqi.SistemasContables.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class INPCs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        public double? Indices1 { get; set; }

        public double? Indices2 { get; set; }

        public double? Indices3 { get; set; }

        public double? Indices4 { get; set; }

        public double? Indices5 { get; set; }

        public double? Indices6 { get; set; }

        public double? Indices7 { get; set; }

        public double? Indices8 { get; set; }

        public double? Indices9 { get; set; }

        public double? Indices10 { get; set; }

        public double? Indices11 { get; set; }

        public double? Indices12 { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
