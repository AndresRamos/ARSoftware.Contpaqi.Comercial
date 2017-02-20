namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NomIDX")]
    public partial class NomIDX
    {
        [StringLength(255)]
        public string Columnas { get; set; }

        [Key]
        public bool Descendente { get; set; }

        [StringLength(255)]
        public string Indice { get; set; }

        [StringLength(255)]
        public string Tabla { get; set; }
    }
}