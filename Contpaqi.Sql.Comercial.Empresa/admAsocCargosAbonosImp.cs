namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admAsocCargosAbonosImp")]
    public partial class admAsocCargosAbonosImp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTOABONO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTOCARGO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string CTEXTOTASA { get; set; }

        public double CNETO { get; set; }

        public double CTASA { get; set; }
    }
}
