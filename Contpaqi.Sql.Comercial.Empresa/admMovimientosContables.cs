namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admMovimientosContables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTOCONTABLE { get; set; }

        public int CIDASIENTOCONTABLE { get; set; }

        [Required]
        [StringLength(250)]
        public string CCUENTA { get; set; }

        public int CTIPOMOVIMIENTO { get; set; }

        public double CIMPORTEBASE { get; set; }

        public double CPORCENTAJE { get; set; }

        public int CORIGENREFERENCIA { get; set; }

        [Required]
        [StringLength(30)]
        public string CREFERENCIA { get; set; }

        public int CORIGENDIARIO { get; set; }

        [Required]
        [StringLength(10)]
        public string CDIARIO { get; set; }

        public int CORIGENCONCEPTO { get; set; }

        [Required]
        [StringLength(100)]
        public string CCONCEPTO { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public int CSUMARIZ { get; set; }

        public int CSUPMOVS0 { get; set; }

        public int CORISEGNEG { get; set; }

        [Required]
        [StringLength(4)]
        public string CSEGNEG { get; set; }

        public int CIMPMONEXT { get; set; }

        public int CIMPMONDOC { get; set; }

        public int CCOMPLEMEN { get; set; }
    }
}
