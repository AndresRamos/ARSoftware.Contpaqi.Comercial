using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admMonedas
    {
        public int CIDMONEDA { get; set; }
        public string CNOMBREMONEDA { get; set; }
        public string CSIMBOLOMONEDA { get; set; }
        public int CPOSICIONSIMBOLO { get; set; }
        public string CPLURAL { get; set; }
        public string CSINGULAR { get; set; }
        public string CDESCRIPCIONPROTEGIDA { get; set; }
        public int CIDBANDERA { get; set; }
        public int CDECIMALESMONEDA { get; set; }
        public string CTIMESTAMP { get; set; }
        public string CCLAVESAT { get; set; }
    }
}
