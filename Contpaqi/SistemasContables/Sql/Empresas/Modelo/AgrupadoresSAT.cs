namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AgrupadoresSAT")]
    public partial class AgrupadoresSAT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public int? CtaMayor { get; set; }

        public int? IdRubro { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
