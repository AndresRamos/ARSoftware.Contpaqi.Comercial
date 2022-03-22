namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATFracciones
    {
        [Key]
        [StringLength(10)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(3)]
        public string CUNIDAD { get; set; }
    }
}
