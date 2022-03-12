using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admVistasRelaciones
    {
        public int CIDRELACION { get; set; }
        public int CIDSISTEMA { get; set; }
        public int CIDIDIOMA { get; set; }
        public string CNOMBRENATIVOTABLA1 { get; set; }
        public string CNOMBRENATIVOTABLA2 { get; set; }
        public string CNOMBRERELACION { get; set; }
        public string CSENTENCIAENLACE { get; set; }
        public string CCAMPONA01 { get; set; }
        public string CFILTRO { get; set; }
        public string CTABLAREL1 { get; set; }
        public string CTABLAREL2 { get; set; }
        public string CFILTROAUX { get; set; }
    }
}
