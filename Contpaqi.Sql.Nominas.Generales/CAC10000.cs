namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAC10000
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public short? Nivel { get; set; }
    }
}
