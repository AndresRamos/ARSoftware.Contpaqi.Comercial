namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asc10001
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string DatabaseName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string TableAlias { get; set; }

        [StringLength(50)]
        public string ItemAlias { get; set; }

        [StringLength(100)]
        public string MainFields { get; set; }

        public bool Global { get; set; }

        public bool Hidden { get; set; }
    }
}
