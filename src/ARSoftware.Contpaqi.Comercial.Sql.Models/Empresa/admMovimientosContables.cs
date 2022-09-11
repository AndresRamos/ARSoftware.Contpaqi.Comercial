using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admMovimientosContables
    {
        public int CIDMOVIMIENTOCONTABLE { get; set; }
        public int CIDASIENTOCONTABLE { get; set; }
        public string CCUENTA { get; set; }
        public int CTIPOMOVIMIENTO { get; set; }
        public double CIMPORTEBASE { get; set; }
        public double CPORCENTAJE { get; set; }
        public int CORIGENREFERENCIA { get; set; }
        public string CREFERENCIA { get; set; }
        public int CORIGENDIARIO { get; set; }
        public string CDIARIO { get; set; }
        public int CORIGENCONCEPTO { get; set; }
        public string CCONCEPTO { get; set; }
        public string CTIMESTAMP { get; set; }
        public int CSUMARIZ { get; set; }
        public int CSUPMOVS0 { get; set; }
        public int CORISEGNEG { get; set; }
        public string CSEGNEG { get; set; }
        public int CIMPMONEXT { get; set; }
        public int CIMPMONDOC { get; set; }
        public int CCOMPLEMEN { get; set; }
    }
}
