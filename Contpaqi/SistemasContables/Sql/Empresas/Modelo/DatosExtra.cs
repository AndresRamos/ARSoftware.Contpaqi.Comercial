namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DatosExtra")]
    public partial class DatosExtra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string TextoExtra1 { get; set; }

        [StringLength(100)]
        public string TextoExtra2 { get; set; }

        [StringLength(100)]
        public string TextoExtra3 { get; set; }

        [StringLength(100)]
        public string TextoExtra4 { get; set; }

        public DateTime? FechaExtra1 { get; set; }

        public double? ImporteExtra1 { get; set; }

        public double? ImporteExtra2 { get; set; }

        public double? ImporteExtra3 { get; set; }

        public double? ImporteExtra4 { get; set; }
    }
}
