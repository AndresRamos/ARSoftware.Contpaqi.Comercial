namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Nom20000
    {
        [StringLength(50)]
        public string Acceso { get; set; }

        [StringLength(10)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUsuario { get; set; }

        [StringLength(15)]
        public string Nombre { get; set; }

        [StringLength(10)]
        public string TipoUsuario { get; set; }
    }
}