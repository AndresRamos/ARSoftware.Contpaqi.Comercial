namespace Contpaqi.Sql.Contabilidad.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListaEmpresas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(254)]
        public string RutaDatos { get; set; }

        [StringLength(254)]
        public string RutaResp { get; set; }

        public DateTime? UltimoResp { get; set; }

        public DateTime? UltimaRest { get; set; }

        [StringLength(254)]
        public string ArchivoUltimoResp { get; set; }

        [Required]
        [StringLength(50)]
        public string AliasBDD { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int? HashSchema { get; set; }

        [StringLength(50)]
        public string ModulosIntegrados { get; set; }

        [StringLength(10)]
        public string VersionBDD { get; set; }
    }
}
