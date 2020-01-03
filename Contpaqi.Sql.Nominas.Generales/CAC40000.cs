namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAC40000
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string IdProceso { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Identificacion { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Grupo { get; set; }

        public double? Mensaje { get; set; }

        public double? WParam { get; set; }

        public double? LParam { get; set; }
    }
}
