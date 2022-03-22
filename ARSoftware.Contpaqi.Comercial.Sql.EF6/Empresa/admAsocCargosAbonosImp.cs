namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
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

        public int CESDETALLE { get; set; }

        public int CTIPOIMP01 { get; set; }

        public int CTIPOFAC01 { get; set; }

        public double CTASACUOTA { get; set; }

        public int CESRETEN01 { get; set; }

        public double CPROPORC01 { get; set; }
    }
}
