namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admVistasRelaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDRELACION { get; set; }

        public int CIDSISTEMA { get; set; }

        public int CIDIDIOMA { get; set; }

        [Required]
        [StringLength(9)]
        public string CNOMBRENATIVOTABLA1 { get; set; }

        [Required]
        [StringLength(9)]
        public string CNOMBRENATIVOTABLA2 { get; set; }

        [Required]
        [StringLength(51)]
        public string CNOMBRERELACION { get; set; }

        [Required]
        [StringLength(127)]
        public string CSENTENCIAENLACE { get; set; }

        [Required]
        [StringLength(51)]
        public string CCAMPONA01 { get; set; }

        [Required]
        [StringLength(254)]
        public string CFILTRO { get; set; }

        [Required]
        [StringLength(9)]
        public string CTABLAREL1 { get; set; }

        [Required]
        [StringLength(9)]
        public string CTABLAREL2 { get; set; }

        [Required]
        [StringLength(53)]
        public string CFILTROAUX { get; set; }
    }
}
