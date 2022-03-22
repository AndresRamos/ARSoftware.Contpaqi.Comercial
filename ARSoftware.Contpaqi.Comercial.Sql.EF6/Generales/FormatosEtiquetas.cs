namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FormatosEtiquetas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDTIPOHOJA { get; set; }

        [Required]
        [StringLength(30)]
        public string CNOMBREHOJA { get; set; }

        public double CLARGOPAPEL { get; set; }

        public double CANCHOPAPEL { get; set; }

        public double CMARGENIZQUIERDO { get; set; }

        public double CMARGENDERECHO { get; set; }

        public double CMARGENINFERIOR { get; set; }

        public double CMARGENSUPERIOR { get; set; }

        public int CNUMETIQUETAS { get; set; }

        public int CNUMRENGLONES { get; set; }
    }
}
