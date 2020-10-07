namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NomIDX")]
    public partial class NomIDX
    {
        [StringLength(255)]
        public string Tabla { get; set; }

        [StringLength(255)]
        public string Indice { get; set; }

        [StringLength(255)]
        public string Columnas { get; set; }

        [Key]
        public bool Descendente { get; set; }
    }
}
