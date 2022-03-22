namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MantenimientoBDDErrores
    {
        [Key]
        [StringLength(36)]
        public string cGuidProceso { get; set; }

        [Required]
        [StringLength(150)]
        public string cAliasBDD { get; set; }

        [StringLength(50)]
        public string cDescripcionError { get; set; }
    }
}
