namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admAsocAcumConceptos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDCONCEPTOTIPOACUMULADO { get; set; }

        public int CIDCONCEPTODOCUMENTO { get; set; }

        public int CIDTIPOACUMULADO { get; set; }

        public int CIMPORTEMODELO { get; set; }

        public int CSUMARESTA { get; set; }
    }
}
