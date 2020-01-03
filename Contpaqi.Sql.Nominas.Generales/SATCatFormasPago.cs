namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SATCatFormasPago")]
    public partial class SATCatFormasPago
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ClaveFormaPago { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
