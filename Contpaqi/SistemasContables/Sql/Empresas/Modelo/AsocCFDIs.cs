namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AsocCFDIs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(36)]
        public string GuidRef { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Referencia { get; set; }

        [Required]
        [StringLength(30)]
        public string AppType { get; set; }
    }
}
