namespace Contpaqi.Sql.Nominas.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VersionDiccionarioCatalogos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VersionActual { get; set; }
    }
}
