namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10033
    {
        [Key]
        public int idmodelo { get; set; }

        [StringLength(255)]
        public string archivo { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }
    }
}
