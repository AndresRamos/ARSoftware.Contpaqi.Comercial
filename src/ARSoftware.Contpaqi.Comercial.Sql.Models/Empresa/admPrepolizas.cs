using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admPrepolizas
    {
        public int CIDPREPOLIZA { get; set; }
        public int CESTADOCONTABLE { get; set; }
        public int EJE { get; set; }
        public int PERIODO { get; set; }
        public int TIPOPOL { get; set; }
        public int NUMPOL { get; set; }
        public int CLASE { get; set; }
        public int IMPRESA { get; set; }
        public string CONCEPTO { get; set; }
        public DateTime FECHA { get; set; }
        public double CARGOS { get; set; }
        public double ABONOS { get; set; }
        public string DIARIO { get; set; }
        public int SISTORIG { get; set; }
        public string CHORA { get; set; }
        public string CGUIDPOLIZA { get; set; }
        public string CIDTRANSACCION { get; set; }
    }
}
