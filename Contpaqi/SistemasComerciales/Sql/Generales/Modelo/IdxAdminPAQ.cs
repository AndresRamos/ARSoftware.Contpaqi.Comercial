namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IdxAdminPAQ")]
    public partial class IdxAdminPAQ
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string TABLA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NOMBRE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string GRUPO { get; set; }

        [Required]
        [StringLength(253)]
        public string DESCRIPCIO { get; set; }

        public byte CASE { get; set; }

        public byte UNIQUE { get; set; }

        public byte DESCENDING { get; set; }
    }
}