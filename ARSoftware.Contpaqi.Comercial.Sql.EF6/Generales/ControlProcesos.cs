namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ControlProcesos
    {
        [Key]
        [StringLength(36)]
        public string cGuidControl { get; set; }

        [StringLength(50)]
        public string cProcesoDescripcion { get; set; }

        public int? cPorcentaje { get; set; }

        public DateTime? cFechaInicial { get; set; }

        public DateTime? cFechaFinal { get; set; }

        public int? cTotalExtraccion { get; set; }

        public int? cTotalProcesado { get; set; }

        [StringLength(50)]
        public string cNombreLog { get; set; }

        [StringLength(50)]
        public string cEstatusProceso { get; set; }
    }
}
