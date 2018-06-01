namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoliosUsados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        public int? IdDocumentoDe { get; set; }

        [StringLength(30)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(15)]
        public string Serie { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public int? Estado { get; set; }
    }
}
