using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admBuzones
{
    public string CINBOXID { get; set; } = null!;

    public string CALIAS { get; set; } = null!;

    public string CSUBSCRIPTIONID { get; set; } = null!;

    public string? CSUBSCRIPTIONKEY { get; set; }

    public string CENCRYPTIONKEYID { get; set; } = null!;

    public DateTime CCREATEDAT { get; set; }

    public DateTime CUPDATEDAT { get; set; }

    public int CTIPO { get; set; }

    public int CESTADO { get; set; }
}
