namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class REPORTS
    {
        [StringLength(40)]
        public string DataViewName { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        [Key]
        [StringLength(40)]
        public string Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] Template { get; set; }
    }
}