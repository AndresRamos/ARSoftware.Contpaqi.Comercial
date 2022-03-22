namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nubeDiarios
    {
        [Key]
        [StringLength(12)]
        public string CCODIGO { get; set; }

        [Required]
        [StringLength(255)]
        public string CNOMBRE { get; set; }

        public int CTIPO { get; set; }
    }
}
