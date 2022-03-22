namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Generales
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ModelosFinancieros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMODELO { get; set; }

        public int CIDSISTEMA { get; set; }

        [Required]
        [StringLength(60)]
        public string CDESCRIPCION { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTA { get; set; }
    }
}
