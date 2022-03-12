using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admMaximosMinimos
    {
        public int CIDAUTOINCSQL { get; set; }
        public int CIDALMACEN { get; set; }
        public int CIDPRODUCTO { get; set; }
        public int CIDPRODUCTOPADRE { get; set; }
        public double CEXISTENCIAMINBASE { get; set; }
        public double CEXISTENCIAMAXBASE { get; set; }
        public double CEXISTMINNOCONVERTIBLE { get; set; }
        public double CEXISTMAXNOCONVERTIBLE { get; set; }
        public string CZONA { get; set; }
        public string CPASILLO { get; set; }
        public string CANAQUEL { get; set; }
        public string CREPISA { get; set; }
    }
}
