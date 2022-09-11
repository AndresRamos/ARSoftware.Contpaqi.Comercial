namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresasModelo")]
    public partial class EmpresasModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEMPRESA { get; set; }

        [Required]
        [StringLength(150)]
        public string CNOMBREEMPRESA { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAARCHIVOS { get; set; }
    }
}
