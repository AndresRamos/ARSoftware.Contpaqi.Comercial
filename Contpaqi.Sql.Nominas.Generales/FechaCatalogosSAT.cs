namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FechaCatalogosSAT")]
    public partial class FechaCatalogosSAT
    {
        [Key]
        public DateTime UltimaActualizacion { get; set; }
    }
}
