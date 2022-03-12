using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admAsientosContables
    {
        public int CIDASIENTOCONTABLE { get; set; }
        public string CNUMEROASIENTOCONTABLE { get; set; }
        public string CNOMBREASIENTOCONTABLE { get; set; }
        public int CFRECUENCIA { get; set; }
        public int CORIGENFECHA { get; set; }
        public int CTIPOPOLIZA { get; set; }
        public int CORIGENNUMERO { get; set; }
        public int CORIGENCONCEPTO { get; set; }
        public string CCONCEPTO { get; set; }
        public string CDIARIO { get; set; }
        public string CTIMESTAMP { get; set; }
    }
}
