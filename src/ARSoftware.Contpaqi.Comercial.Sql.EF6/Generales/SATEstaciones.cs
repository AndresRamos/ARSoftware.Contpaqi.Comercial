namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATEstaciones
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string CDESCRIPCION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string CTIPO { get; set; }

        [Required]
        [StringLength(30)]
        public string CNACIONALIDAD { get; set; }

        [Required]
        [StringLength(20)]
        public string CEXTRA { get; set; }
    }
}
