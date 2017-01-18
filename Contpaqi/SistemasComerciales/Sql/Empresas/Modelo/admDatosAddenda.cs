namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admDatosAddenda")]
    public partial class admDatosAddenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDADDENDA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPOCAT { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCAT { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMCAMPO { get; set; }

        [Required]
        [StringLength(254)]
        public string VALOR { get; set; }
    }
}
