namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admCapasProducto")]
    public partial class admCapasProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCAPA { get; set; }

        public int CIDALMACEN { get; set; }

        public int CIDPRODUCTO { get; set; }

        public DateTime CFECHA { get; set; }

        public int CTIPOCAPA { get; set; }

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

        public double CEXISTENCIA { get; set; }

        public double CCOSTO { get; set; }

        public int CIDCAPAORIGEN { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CNUMADUANA { get; set; }

        [Required]
        [StringLength(30)]
        public string CCLAVESAT { get; set; }
    }
}
