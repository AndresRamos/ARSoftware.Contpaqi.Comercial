namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DDTABLE")]
    public partial class DDTABLE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string databasename { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string tablename { get; set; }

        [StringLength(50)]
        public string tablealias { get; set; }

        [StringLength(50)]
        public string group { get; set; }
    }
}
