namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asociaciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdCtaSup { get; set; }

        public int IdSubCtade { get; set; }

        [Required]
        [StringLength(30)]
        public string CtaSup { get; set; }

        [Required]
        [StringLength(30)]
        public string SubCtade { get; set; }

        public int TipoRel { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
