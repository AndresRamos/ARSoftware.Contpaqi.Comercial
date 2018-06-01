namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmisionesContabilidadElectronica")]
    public partial class EmisionesContabilidadElectronica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public DateTime Fecha { get; set; }

        public int? Anio { get; set; }

        public int? Mes { get; set; }

        [StringLength(2)]
        public string TipoSolicitud { get; set; }

        public int? TipoArchivo { get; set; }

        [StringLength(13)]
        public string NumOrden { get; set; }

        [StringLength(10)]
        public string NumTramite { get; set; }

        [StringLength(22)]
        public string Folio { get; set; }

        public DateTime? FechaModBal { get; set; }

        public int? EstadoPSRDD { get; set; }

        public int? EstadoDocto { get; set; }

        public int? EstadoSAT { get; set; }

        [StringLength(20)]
        public string UsuarioCrea { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        [StringLength(36)]
        public string GuidAcuse { get; set; }

        public int? TipoEntrega { get; set; }
    }
}
