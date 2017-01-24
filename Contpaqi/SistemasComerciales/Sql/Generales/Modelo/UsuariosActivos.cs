namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UsuariosActivos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUSUARIO { get; set; }

        [Required]
        [StringLength(30)]
        public string CUSUARIO { get; set; }

        [Required]
        [StringLength(150)]
        public string CEMPRESA { get; set; }
    }
}