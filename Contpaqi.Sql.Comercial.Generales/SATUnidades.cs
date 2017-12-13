namespace Contpaqi.Sql.Comercial.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATUnidades
    {
        [Key]
        [StringLength(3)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(100)]
        public string CNOMBRE { get; set; }

        [Required]
        [StringLength(512)]
        public string CDESCRIPCION { get; set; }
    }
}
