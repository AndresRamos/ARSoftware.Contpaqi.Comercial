namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10032
    {
        [Key]
        public int idturno { get; set; }

        public int? numeroturno { get; set; }

        [StringLength(40)]
        public string descripcion { get; set; }

        public double? numerohoras { get; set; }

        public DateTime? timestamp { get; set; }

        [Required]
        [StringLength(3)]
        public string TipoJornada { get; set; }
    }
}
