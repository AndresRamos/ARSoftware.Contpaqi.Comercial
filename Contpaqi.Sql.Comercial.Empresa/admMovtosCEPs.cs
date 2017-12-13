namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admMovtosCEPs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVTOCEP { get; set; }

        public int CIDDOCUMENTO { get; set; }

        public DateTime CFECHA { get; set; }

        [Required]
        [StringLength(8)]
        public string CHORA { get; set; }

        [Required]
        [StringLength(12)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(256)]
        public string CSELLO { get; set; }

        [Required]
        [StringLength(20)]
        public string CCERTIFICADO { get; set; }

        [Column(TypeName = "text")]
        public string CCADENA { get; set; }

        public int CESTADO { get; set; }

        [Required]
        [StringLength(60)]
        public string CCONCEPTO { get; set; }

        public double CIVA { get; set; }

        public double CIMPORTE { get; set; }

        [Required]
        [StringLength(60)]
        public string CRBANCO { get; set; }

        [Required]
        [StringLength(60)]
        public string CRNOMBRE { get; set; }

        [Required]
        [StringLength(20)]
        public string CRRFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CRCUENTA { get; set; }

        [Required]
        [StringLength(2)]
        public string CRTIPOCTA { get; set; }

        [Required]
        [StringLength(60)]
        public string CEBANCO { get; set; }

        [Required]
        [StringLength(60)]
        public string CENOMBRE { get; set; }

        [Required]
        [StringLength(20)]
        public string CERFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CECUENTA { get; set; }

        [Required]
        [StringLength(2)]
        public string CETIPOCTA { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        [Required]
        [StringLength(256)]
        public string CARCHIVO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }
    }
}
