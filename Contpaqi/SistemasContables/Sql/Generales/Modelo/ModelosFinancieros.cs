namespace Contpaqi.SistemasContables.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ModelosFinancieros
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(254)]
        public string Archivo { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
