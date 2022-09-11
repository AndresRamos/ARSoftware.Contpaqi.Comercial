namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admMaximosMinimos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDALMACEN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPRODUCTO { get; set; }

        public int CIDPRODUCTOPADRE { get; set; }

        public double CEXISTENCIAMINBASE { get; set; }

        public double CEXISTENCIAMAXBASE { get; set; }

        public double CEXISTMINNOCONVERTIBLE { get; set; }

        public double CEXISTMAXNOCONVERTIBLE { get; set; }

        [Required]
        [StringLength(60)]
        public string CZONA { get; set; }

        [Required]
        [StringLength(60)]
        public string CPASILLO { get; set; }

        [Required]
        [StringLength(60)]
        public string CANAQUEL { get; set; }

        [Required]
        [StringLength(60)]
        public string CREPISA { get; set; }
    }
}
