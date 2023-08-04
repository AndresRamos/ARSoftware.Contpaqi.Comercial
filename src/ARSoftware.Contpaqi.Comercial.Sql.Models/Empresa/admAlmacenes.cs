using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAlmacenes
{
    public int CIDALMACEN { get; set; }

    public string CCODIGOALMACEN { get; set; } = null!;

    public string CNOMBREALMACEN { get; set; } = null!;

    public DateTime CFECHAALTAALMACEN { get; set; }

    public int CIDVALORCLASIFICACION1 { get; set; }

    public int CIDVALORCLASIFICACION2 { get; set; }

    public int CIDVALORCLASIFICACION3 { get; set; }

    public int CIDVALORCLASIFICACION4 { get; set; }

    public int CIDVALORCLASIFICACION5 { get; set; }

    public int CIDVALORCLASIFICACION6 { get; set; }

    public string CSEGCONTALMACEN { get; set; } = null!;

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public int CBANDOMICILIO { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public string CSCALMAC2 { get; set; } = null!;

    public string CSCALMAC3 { get; set; } = null!;

    public int CSISTORIG { get; set; }
}
