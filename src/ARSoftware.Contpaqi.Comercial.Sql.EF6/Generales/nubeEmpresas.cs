namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nubeEmpresas
    {
        [Key]
        [StringLength(253)]
        public string CIDEMPRESA { get; set; }

        [Required]
        [StringLength(253)]
        public string CEMPRESA { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CTIPO { get; set; }

        [Required]
        [StringLength(150)]
        public string CPROPIETARIO { get; set; }
    }
}
