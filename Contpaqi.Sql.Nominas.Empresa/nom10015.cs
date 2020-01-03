namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10015
    {
        [Key]
        public int idpoliza { get; set; }

        public int? idperiodo { get; set; }

        [StringLength(1)]
        public string estadocontab { get; set; }

        public DateTime? fechapoliza { get; set; }

        public int? tipopoliza { get; set; }

        public int? numeropoliza { get; set; }

        [StringLength(100)]
        public string concepto { get; set; }

        [StringLength(20)]
        public string diario { get; set; }

        [StringLength(40)]
        public string GUIDPoliza { get; set; }
    }
}
