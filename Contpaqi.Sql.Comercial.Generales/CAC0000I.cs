namespace Contpaqi.Sql.Comercial.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAC0000I
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string TABLA { get; set; }

        [Required]
        [StringLength(25)]
        public string LARGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CORTO { get; set; }
    }
}
