using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admCaracteristicasValores
    {
        public int CIDVALORCARACTERISTICA { get; set; }
        public int CIDPADRECARACTERISTICA { get; set; }
        public string CVALORCARACTERISTICA { get; set; }
        public string CNEMOCARACTERISTICA { get; set; }
    }
}
