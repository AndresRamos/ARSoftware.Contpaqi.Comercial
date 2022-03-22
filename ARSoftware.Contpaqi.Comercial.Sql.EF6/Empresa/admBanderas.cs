namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admBanderas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDBANDERA { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBREBANDERA { get; set; }

        [Column(TypeName = "text")]
        public string CBANDERA { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVEISO { get; set; }
    }
}
