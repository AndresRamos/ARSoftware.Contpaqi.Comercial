namespace Contpaqi.Sql.Comercial.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anexos20
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDESQUEMA { get; set; }

        public int CTIPODOCTO { get; set; }

        [Required]
        [StringLength(6)]
        public string CVERSION { get; set; }

        public DateTime CFECHAFIN { get; set; }
    }
}
