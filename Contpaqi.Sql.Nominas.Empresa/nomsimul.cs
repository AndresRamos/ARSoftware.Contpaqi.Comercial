namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nomsimul")]
    public partial class nomsimul
    {
        [Key]
        public int idresultado { get; set; }

        public int? idempleado { get; set; }

        [StringLength(110)]
        public string nombre { get; set; }

        [StringLength(10)]
        public string ids { get; set; }

        [StringLength(10)]
        public string consecutivo { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [Column(TypeName = "text")]
        public string expresion { get; set; }

        public double? resultado { get; set; }
    }
}
