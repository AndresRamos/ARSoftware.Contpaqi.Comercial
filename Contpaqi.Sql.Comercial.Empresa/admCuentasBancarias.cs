namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admCuentasBancarias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCUENTA { get; set; }

        [Required]
        [StringLength(26)]
        public string CACCOUNTID { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMEROCUENTA { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBRECUENTA { get; set; }

        public DateTime CFECHAALTA { get; set; }

        public DateTime CFECHABAJA { get; set; }

        public int CESTATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string CCLABE { get; set; }

        [Required]
        [StringLength(3)]
        public string CCLAVE { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT01 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT02 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONT03 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CIDMONEDA { get; set; }

        public int CIDCATALOGO { get; set; }

        public int CTIPOCATALOGO { get; set; }

        [Required]
        [StringLength(254)]
        public string CNOMBANEXT { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFCBANCO { get; set; }
    }
}
