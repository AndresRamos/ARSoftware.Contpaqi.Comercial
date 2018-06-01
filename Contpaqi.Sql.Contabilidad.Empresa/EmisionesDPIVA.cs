namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmisionesDPIVA")]
    public partial class EmisionesDPIVA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Ejercicio { get; set; }

        public int TipoPeriodo { get; set; }

        public int Periodo { get; set; }

        public int TipoDeclaracion { get; set; }

        public bool DPIVA { get; set; }

        [StringLength(16)]
        public string NoOperacion { get; set; }

        [StringLength(16)]
        public string FolioAnt { get; set; }

        public DateTime? FechaPresAnt { get; set; }

        public DateTime? Fecha { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        public int? EstadoPSRDD { get; set; }

        public int? EstadoDocto { get; set; }

        public int? EstadoSAT { get; set; }

        [StringLength(20)]
        public string UsuarioCrea { get; set; }

        [StringLength(36)]
        public string GuidAcuse { get; set; }

        public int? MesInicial { get; set; }

        public int? MesFinal { get; set; }

        public int TipoEntrega { get; set; }

        [StringLength(36)]
        public string GuidPDF_Acuse { get; set; }

        public bool? Visto { get; set; }
    }
}
