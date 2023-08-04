using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class nubeCuentas
{
    public string CCUENTA { get; set; } = null!;

    public string CNOMBRE { get; set; } = null!;

    public int CESTATUS { get; set; }

    public int CFLUJOEFECTIVO { get; set; }

    public string CTIPO { get; set; } = null!;

    public string CMONEDA { get; set; } = null!;

    public int CAFECTABLE { get; set; }

    public string CSEGMENTO { get; set; } = null!;
}
