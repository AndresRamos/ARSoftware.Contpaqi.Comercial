namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admDocumentosModelosBack")]
    public partial class admDocumentosModelosBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CDESCRIPCION { get; set; }

        public int CNATURALEZA { get; set; }

        public int CAFECTAEXISTENCIA { get; set; }

        public int CMODULO { get; set; }

        public double CNOFOLIO { get; set; }

        public int CIDCONCEPTODOCTOASUMIDO { get; set; }

        public int CUSACLIENTE { get; set; }

        public int CUSAPROVEEDOR { get; set; }

        public int CIDASIENTOCONTABLE { get; set; }
    }
}
