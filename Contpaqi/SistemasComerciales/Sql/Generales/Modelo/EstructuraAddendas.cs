namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class EstructuraAddendas
    {
        [Key]
        public int CIDAUTOINCSQL { get; set; }

        public int IDADDENDA { get; set; }

        public int ORDEN { get; set; }

        [Required]
        [StringLength(254)]
        public string STRINICIO { get; set; }

        [Required]
        [StringLength(254)]
        public string STRFIN { get; set; }

        [Required]
        [StringLength(25)]
        public string ORIGENDATO { get; set; }

        [Required]
        [StringLength(50)]
        public string FORMATO { get; set; }

        [Column(TypeName = "text")]
        public string DATO { get; set; }

        public byte MAP { get; set; }

        [Column(TypeName = "text")]
        public string MAPVALUES { get; set; }

        public byte OBLIGATORI { get; set; }

        public int MIN { get; set; }

        public int MAX { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCIO { get; set; }

        public byte DEP { get; set; }

        [Required]
        [StringLength(25)]
        public string DEPFUNC { get; set; }

        public int ENCADORIG { get; set; }

        public int ORDCADORIG { get; set; }
    }
}