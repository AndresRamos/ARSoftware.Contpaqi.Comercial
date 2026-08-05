using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admFormasPago
{
    public int CIDFORMAPAGO { get; set; }

    public string CCODIGOFORMAPAGO { get; set; } = null!;

    public string CNOMBREFORMAPAGO { get; set; } = null!;

    public int CESTATUS { get; set; }

    public DateTime CFECHAALTA { get; set; }

    public DateTime CFECHABAJA { get; set; }

    public string CCLAVESAT { get; set; } = null!;

    public int CIDMONEDA { get; set; }

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
