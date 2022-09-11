using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admBitacoras
    {
        public int IDBITACORA { get; set; }
        public DateTime FECHA { get; set; }
        public string HORA { get; set; }
        public string USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string USUARIO2 { get; set; }
        public string NOMBRE2 { get; set; }
        public string PROCESO { get; set; }
        public string DATOS { get; set; }
        public int IDSISTEMA { get; set; }
        public string CTEXTOEX01 { get; set; }
        public string CTEXTOEX02 { get; set; }
        public string CTEXTOEX03 { get; set; }
        public DateTime CFECHAEX01 { get; set; }
        public double CIMPORTE01 { get; set; }
        public double CIMPORTE02 { get; set; }
        public double CIMPORTE03 { get; set; }
    }
}
