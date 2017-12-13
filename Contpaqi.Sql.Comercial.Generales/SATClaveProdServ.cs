namespace Contpaqi.Sql.Comercial.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SATClaveProdServ")]
    public partial class SATClaveProdServ
    {
        [Key]
        [StringLength(10)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(152)]
        public string CDESCRIPCION { get; set; }
    }
}
