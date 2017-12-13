namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admMovtosInvFisicoSerieCa")]
    public partial class admMovtosInvFisicoSerieCa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDSERIECAPA { get; set; }

        public int CIDMOVTOINVENTARIOFISICO { get; set; }

        public int CIDPRODUCTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROSERIE { get; set; }

        public int CIDALMACEN { get; set; }

        public int CTIPO { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROLOTE { get; set; }

        public DateTime CFECHACADUCIDAD { get; set; }

        public DateTime CFECHAFABRICACION { get; set; }

        [Required]
        [StringLength(30)]
        public string CPEDIMENTO { get; set; }

        [Required]
        [StringLength(60)]
        public string CADUANA { get; set; }

        public DateTime CFECHAPEDIMENTO { get; set; }

        public double CTIPOCAMBIO { get; set; }

        public double CCANTIDAD { get; set; }

        public int CIDCAPA { get; set; }
    }
}
