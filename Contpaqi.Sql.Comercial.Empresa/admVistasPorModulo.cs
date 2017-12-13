namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admVistasPorModulo")]
    public partial class admVistasPorModulo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMODULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDSISTEMA { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDIDIOMA { get; set; }

        [Required]
        [StringLength(51)]
        public string CNOMBREMODULO { get; set; }

        public int CASPECTO { get; set; }

        public int CACTUALIZA { get; set; }
    }
}
