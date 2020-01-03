namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nom40000
    {
        [Key]
        public int NumeroTabla { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
