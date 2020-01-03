namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10036
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        public string sentenciaSQL { get; set; }

        public bool? activa { get; set; }
    }
}
