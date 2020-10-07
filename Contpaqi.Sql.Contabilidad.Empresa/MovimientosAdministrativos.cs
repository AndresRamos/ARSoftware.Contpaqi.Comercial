namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MovimientosAdministrativos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdDoctoAdmvo { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        public int NumMovto { get; set; }

        [StringLength(20)]
        public string CodigoTipoOperacion { get; set; }

        [StringLength(20)]
        public string CodigoSegmentoNegocio { get; set; }

        [StringLength(8)]
        public string CveProdSAT { get; set; }

        [StringLength(20)]
        public string CodigoProducto { get; set; }
    }
}
