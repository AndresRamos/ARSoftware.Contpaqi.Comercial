using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Generales
{
    public partial class IdxAdminPAQ
    {
        public int CIDAUTOINCSQL { get; set; }
        public string TABLA { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }
        public string GRUPO { get; set; }
        public string DESCRIPCIO { get; set; }
        public byte CASE { get; set; }
        public byte UNIQUE { get; set; }
        public byte DESCENDING { get; set; }
    }
}
