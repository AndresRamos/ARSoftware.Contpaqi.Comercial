using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admPagoNotas
{
    public int CIDPAGO { get; set; }

    public int CIDDOCUMENTO { get; set; }

    public int CIDFORMAPAGO { get; set; }

    public int CTIPO { get; set; }

    public double CIMPORTE { get; set; }

    public int CIDMONEDA { get; set; }

    public double CTIPOCAMBIO { get; set; }

    public string CREFERENCIA { get; set; } = null!;

    public string CTIMESTAMP { get; set; } = null!;
}
