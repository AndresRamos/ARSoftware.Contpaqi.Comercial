using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovtosCEPs
{
    public int CIDMOVTOCEP { get; set; }

    public int CIDDOCUMENTO { get; set; }

    public DateTime CFECHA { get; set; }

    public string CHORA { get; set; } = null!;

    public string CCLAVE { get; set; } = null!;

    public string CSELLO { get; set; } = null!;

    public string CCERTIFICADO { get; set; } = null!;

    public string? CCADENA { get; set; }

    public int CESTADO { get; set; }

    public string CCONCEPTO { get; set; } = null!;

    public double CIVA { get; set; }

    public double CIMPORTE { get; set; }

    public string CRBANCO { get; set; } = null!;

    public string CRNOMBRE { get; set; } = null!;

    public string CRRFC { get; set; } = null!;

    public string CRCUENTA { get; set; } = null!;

    public string CRTIPOCTA { get; set; } = null!;

    public string CEBANCO { get; set; } = null!;

    public string CENOMBRE { get; set; } = null!;

    public string CERFC { get; set; } = null!;

    public string CECUENTA { get; set; } = null!;

    public string CETIPOCTA { get; set; } = null!;

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CARCHIVO { get; set; } = null!;

    public string CTIMESTAMP { get; set; } = null!;
}
