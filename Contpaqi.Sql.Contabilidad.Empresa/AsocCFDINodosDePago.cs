namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsocCFDINodosDePago")]
    public partial class AsocCFDINodosDePago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(36)]
        public string UUIDRep { get; set; }

        public int NumNodoPago { get; set; }

        [Required]
        [StringLength(36)]
        public string GuidReferencia { get; set; }

        [StringLength(30)]
        public string AplicationType { get; set; }
    }
}
