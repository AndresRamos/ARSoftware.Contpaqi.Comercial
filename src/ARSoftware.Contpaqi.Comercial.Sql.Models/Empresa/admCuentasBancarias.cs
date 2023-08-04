using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admCuentasBancarias
{
    public int CIDCUENTA { get; set; }

    public string CACCOUNTID { get; set; } = null!;

    public string CNUMEROCUENTA { get; set; } = null!;

    public string CNOMBRECUENTA { get; set; } = null!;

    public DateTime CFECHAALTA { get; set; }

    public DateTime CFECHABAJA { get; set; }

    public int CESTATUS { get; set; }

    public string CCLABE { get; set; } = null!;

    public string CCLAVE { get; set; } = null!;

    public string CSEGCONT01 { get; set; } = null!;

    public string CSEGCONT02 { get; set; } = null!;

    public string CSEGCONT03 { get; set; } = null!;

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public int CIDMONEDA { get; set; }

    public int CIDCATALOGO { get; set; }

    public int CTIPOCATALOGO { get; set; }

    public string CNOMBANEXT { get; set; } = null!;

    public string CRFCBANCO { get; set; } = null!;
}
