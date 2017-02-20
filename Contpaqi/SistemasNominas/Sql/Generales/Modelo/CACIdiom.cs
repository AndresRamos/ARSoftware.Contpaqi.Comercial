namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CACIdiom")]
    public partial class CACIdiom
    {
        public int? IdAyuda { get; set; }

        [StringLength(25)]
        public string NombreArchivoAyuda { get; set; }

        [StringLength(25)]
        public string NombreArchivoBDD { get; set; }

        [StringLength(20)]
        public string NombreDLLApp { get; set; }

        [StringLength(20)]
        public string NombreDLLErr { get; set; }

        [StringLength(60)]
        public string NombreIdioma { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroIdioma { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroSistema { get; set; }
    }
}