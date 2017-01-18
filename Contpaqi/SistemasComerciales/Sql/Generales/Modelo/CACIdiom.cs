namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CACIdiom")]
    public partial class CACIdiom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMEROSISTEMA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMEROIDIOMA { get; set; }

        [Required]
        [StringLength(60)]
        public string NOMBREIDIOMA { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBREDLLAPP { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBREDLLERR { get; set; }

        [Required]
        [StringLength(25)]
        public string ARCHBDD { get; set; }

        [Required]
        [StringLength(25)]
        public string ARCHAYUDA { get; set; }

        public int IDAYUDA { get; set; }
    }
}
