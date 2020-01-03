namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VistaRelacion")]
    public partial class VistaRelacion
    {
        public int id { get; set; }

        public int? idtabla { get; set; }

        public int? idtabladestino { get; set; }

        [StringLength(30)]
        public string campo { get; set; }

        [StringLength(30)]
        public string campodestino { get; set; }
    }
}
