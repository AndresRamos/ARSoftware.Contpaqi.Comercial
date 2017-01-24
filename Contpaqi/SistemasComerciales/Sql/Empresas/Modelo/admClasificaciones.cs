namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admClasificaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCLASIFICACION { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECLASIFICACION { get; set; }
    }
}