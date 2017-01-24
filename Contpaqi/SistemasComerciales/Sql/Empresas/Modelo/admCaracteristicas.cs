namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class admCaracteristicas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPADRECARACTERISTICA { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECARACTERISTICA { get; set; }
    }
}