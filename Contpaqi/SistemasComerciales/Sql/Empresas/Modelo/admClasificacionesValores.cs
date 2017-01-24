namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admClasificacionesValores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDVALORCLASIFICACION { get; set; }

        [Required]
        [StringLength(60)]
        public string CVALORCLASIFICACION { get; set; }

        public int CIDCLASIFICACION { get; set; }

        [Required]
        [StringLength(3)]
        public string CCODIGOVALORCLASIFICACION { get; set; }
    }
}