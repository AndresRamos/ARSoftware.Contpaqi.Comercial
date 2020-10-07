namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10027
    {
        [Key]
        public int numerotabla { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public DateTime? timestamp { get; set; }
    }
}
