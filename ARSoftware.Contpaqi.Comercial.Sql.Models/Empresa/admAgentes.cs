using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Empresa
{
    public partial class admAgentes
    {
        public int CIDAGENTE { get; set; }
        public string CCODIGOAGENTE { get; set; }
        public string CNOMBREAGENTE { get; set; }
        public DateTime CFECHAALTAAGENTE { get; set; }
        public int CTIPOAGENTE { get; set; }
        public double CCOMISIONVENTAAGENTE { get; set; }
        public double CCOMISIONCOBROAGENTE { get; set; }
        public int CIDCLIENTE { get; set; }
        public int CIDPROVEEDOR { get; set; }
        public int CIDVALORCLASIFICACION1 { get; set; }
        public int CIDVALORCLASIFICACION2 { get; set; }
        public int CIDVALORCLASIFICACION3 { get; set; }
        public int CIDVALORCLASIFICACION4 { get; set; }
        public int CIDVALORCLASIFICACION5 { get; set; }
        public int CIDVALORCLASIFICACION6 { get; set; }
        public string CSEGCONTAGENTE { get; set; }
        public string CTEXTOEXTRA1 { get; set; }
        public string CTEXTOEXTRA2 { get; set; }
        public string CTEXTOEXTRA3 { get; set; }
        public DateTime CFECHAEXTRA { get; set; }
        public double CIMPORTEEXTRA1 { get; set; }
        public double CIMPORTEEXTRA2 { get; set; }
        public double CIMPORTEEXTRA3 { get; set; }
        public double CIMPORTEEXTRA4 { get; set; }
        public string CTIMESTAMP { get; set; }
        public string CSCAGENTE2 { get; set; }
        public string CSCAGENTE3 { get; set; }
    }
}
