using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admBanderas
{
    public int CIDBANDERA { get; set; }

    public string CNOMBREBANDERA { get; set; } = null!;

    public string? CBANDERA { get; set; }

    public string CCLAVEISO { get; set; } = null!;
}
