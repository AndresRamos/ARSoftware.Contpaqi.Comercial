namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10020
    {
        [Key]
        public int idbajareingreso { get; set; }

        public int? idempleado { get; set; }

        [StringLength(1)]
        public string clavebajareingreso { get; set; }

        public DateTime? fecha { get; set; }

        public int? cidperiodo { get; set; }

        public int? cidtipoperiodo { get; set; }
    }
}
