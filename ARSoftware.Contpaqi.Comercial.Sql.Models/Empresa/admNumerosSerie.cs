using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admNumerosSerie
    {
        public int CIDSERIE { get; set; }
        public int CIDPRODUCTO { get; set; }
        public string CNUMEROSERIE { get; set; }
        public int CIDALMACEN { get; set; }
        public int CESTADO { get; set; }
        public int CESTADOANTERIOR { get; set; }
        public string CNUMEROLOTE { get; set; }
        public DateTime CFECHACADUCIDAD { get; set; }
        public DateTime CFECHAFABRICACION { get; set; }
        public string CPEDIMENTO { get; set; }
        public string CADUANA { get; set; }
        public DateTime CFECHAPEDIMENTO { get; set; }
        public double CTIPOCAMBIO { get; set; }
        public double CCOSTO { get; set; }
        public string CTIMESTAMP { get; set; }
        public int CNUMADUANA { get; set; }
        public string CCLAVESAT { get; set; }
    }
}
