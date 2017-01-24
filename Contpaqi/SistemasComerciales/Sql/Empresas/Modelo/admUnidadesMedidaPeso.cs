namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admUnidadesMedidaPeso")]
    public partial class admUnidadesMedidaPeso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUNIDAD { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREUNIDAD { get; set; }

        [Required]
        [StringLength(3)]
        public string CABREVIATURA { get; set; }

        [Required]
        [StringLength(3)]
        public string CDESPLIEGUE { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVEINT { get; set; }
    }
}