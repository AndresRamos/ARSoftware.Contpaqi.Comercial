namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admCaracteristicasValores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDVALORCARACTERISTICA { get; set; }

        public int CIDPADRECARACTERISTICA { get; set; }

        [Required]
        [StringLength(20)]
        public string CVALORCARACTERISTICA { get; set; }

        [Required]
        [StringLength(3)]
        public string CNEMOCARACTERISTICA { get; set; }
    }
}
