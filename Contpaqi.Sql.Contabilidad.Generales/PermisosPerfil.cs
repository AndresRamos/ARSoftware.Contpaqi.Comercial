namespace Contpaqi.Sql.Contabilidad.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermisosPerfil")]
    public partial class PermisosPerfil
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdPerfil { get; set; }

        public int IdProceso { get; set; }

        public int Permisos { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
