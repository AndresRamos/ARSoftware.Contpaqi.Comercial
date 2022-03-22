namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admMovtosBancarios
    {
        [Key]
        [StringLength(26)]
        public string CTRANSACTIONID { get; set; }

        [Required]
        [StringLength(26)]
        public string CACCOUNTID { get; set; }

        public int CIDCUENTA { get; set; }

        public int CIDDOCUMENTO { get; set; }

        public DateTime CFECHA { get; set; }

        [Required]
        [StringLength(256)]
        public string CDESCRIPCION { get; set; }

        [Required]
        [StringLength(128)]
        public string CREFERENCIA { get; set; }

        public double CIMPORTE { get; set; }

        public int CESTADO { get; set; }

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
    }
}
