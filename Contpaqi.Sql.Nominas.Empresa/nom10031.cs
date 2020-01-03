namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10031
    {
        [Key]
        public int idformula { get; set; }

        public int? idcategoria { get; set; }

        [StringLength(40)]
        public string nombre { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public int? posicion { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        [Column(TypeName = "text")]
        public string ayuda { get; set; }

        [Column(TypeName = "text")]
        public string expresion { get; set; }

        public bool modificado { get; set; }

        public DateTime? timestamp { get; set; }

        public int? version { get; set; }
    }
}
