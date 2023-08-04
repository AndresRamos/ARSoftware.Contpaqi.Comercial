using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class SATMonedas
{
    public string CCODIGO { get; set; } = null!;

    public string CNOMBRE { get; set; } = null!;

    public int CDECIMALES { get; set; }
}
