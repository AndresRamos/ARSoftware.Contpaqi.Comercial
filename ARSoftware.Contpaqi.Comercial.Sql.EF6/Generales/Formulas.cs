namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Formulas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDFORMULA { get; set; }

        [Required]
        [StringLength(150)]
        public string CDESCRIPCION { get; set; }

        [Required]
        [StringLength(50)]
        public string CNOMBRE { get; set; }

        public int CAGRUPADOR { get; set; }

        [Column(TypeName = "text")]
        public string CDESCRIPCIONEJEMPLO { get; set; }
    }
}
