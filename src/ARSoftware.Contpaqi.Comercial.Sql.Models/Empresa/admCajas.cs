using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admCajas
{
    public int CIDCAJA { get; set; }

    public string CCODIGOCAJA { get; set; } = null!;

    public string CNOMBRECAJA { get; set; } = null!;

    public int CESTATUS { get; set; }

    public DateTime CFECHAALTA { get; set; }

    public DateTime CFECHABAJA { get; set; }

    public int CIDVALORCLASIFICACION1 { get; set; }

    public double CFOLIONOTA { get; set; }

    public string CSERIENOTA { get; set; } = null!;

    public double CFOLIODEVN { get; set; }

    public string CSERIEDEVN { get; set; } = null!;

    public int CIDALMACEN { get; set; }

    public int CIDUSUARIO { get; set; }

    public int CIDCLIENTE { get; set; }

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public string cReporteApertura { get; set; } = null!;

    public string cReporteCorte { get; set; } = null!;

    public string cReporteNota { get; set; } = null!;
}
