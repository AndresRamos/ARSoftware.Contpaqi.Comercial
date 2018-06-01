namespace Contpaqi.Sql.Contabilidad.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Procesos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int Tipo { get; set; }

        public int Sistema { get; set; }

        public int Permisos { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int? SistemaIntegrado { get; set; }
    }
}
