using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class SATClaveProdServ
{
    public string CCLAVE { get; set; } = null!;

    public string CDESCRIPCION { get; set; } = null!;

    public int CESTATUS { get; set; }
}
