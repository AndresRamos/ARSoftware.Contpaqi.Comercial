namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admPrepolizas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDPREPOLIZA { get; set; }

        public int CESTADOCONTABLE { get; set; }

        public int EJE { get; set; }

        public int PERIODO { get; set; }

        public int TIPOPOL { get; set; }

        public int NUMPOL { get; set; }

        public int CLASE { get; set; }

        public int IMPRESA { get; set; }

        [Required]
        [StringLength(50)]
        public string CONCEPTO { get; set; }

        public DateTime FECHA { get; set; }

        public double CARGOS { get; set; }

        public double ABONOS { get; set; }

        [Required]
        [StringLength(10)]
        public string DIARIO { get; set; }

        public int SISTORIG { get; set; }

        [Required]
        [StringLength(8)]
        public string CHORA { get; set; }

        [Required]
        [StringLength(40)]
        public string CGUIDPOLIZA { get; set; }
    }
}
