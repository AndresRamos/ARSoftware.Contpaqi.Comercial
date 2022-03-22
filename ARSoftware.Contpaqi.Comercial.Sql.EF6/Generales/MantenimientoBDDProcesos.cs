namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MantenimientoBDDProcesos
    {
        [Key]
        [StringLength(36)]
        public string cGuidProceso { get; set; }

        public DateTime? cFechaInicial { get; set; }

        public DateTime? cFechaFinal { get; set; }

        public int? cLogsEliminados { get; set; }

        public int? cIndicesReorganizados { get; set; }

        public int? cIndicesReconstruidos { get; set; }

        public int? cUpdStatix { get; set; }
    }
}
