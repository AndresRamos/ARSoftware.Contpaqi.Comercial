namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admProductosFotos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDFOTOPRODUCTO { get; set; }

        [Required]
        [StringLength(40)]
        public string CNOMBREFOTOPRODUCTO { get; set; }

        [Column(TypeName = "text")]
        public string CFOTOPRODUCTO { get; set; }
    }
}
