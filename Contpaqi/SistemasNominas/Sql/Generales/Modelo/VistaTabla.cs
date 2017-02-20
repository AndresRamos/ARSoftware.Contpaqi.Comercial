namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VistaTabla")]
    public partial class VistaTabla
    {
        [StringLength(30)]
        public string alias { get; set; }

        [Key]
        public int idtabla { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }
    }
}