namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATBancos
    {
        [Key]
        [StringLength(3)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBRE { get; set; }

        [Required]
        [StringLength(150)]
        public string CDESCRIPCION { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(250)]
        public string CPAGINAWEB { get; set; }
    }
}
