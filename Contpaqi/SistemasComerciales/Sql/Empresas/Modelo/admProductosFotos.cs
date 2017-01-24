namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admProductosFotos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDFOTOPRODUCTO { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBREFOTOPRODUCTO { get; set; }

        [Column(TypeName = "text")]
        public string CFOTOPRODUCTO { get; set; }
    }
}