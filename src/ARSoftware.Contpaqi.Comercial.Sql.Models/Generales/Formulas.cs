using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class Formulas
{
    public int CIDFORMULA { get; set; }

    public string CDESCRIPCION { get; set; } = null!;

    public string CNOMBRE { get; set; } = null!;

    public int CAGRUPADOR { get; set; }

    public string? CDESCRIPCIONEJEMPLO { get; set; }
}
