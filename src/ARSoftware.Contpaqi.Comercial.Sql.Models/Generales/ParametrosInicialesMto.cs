using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class ParametrosInicialesMto
{
    public string cDBTemplate { get; set; } = null!;

    public int? cLogSize { get; set; }

    public int? cLogLevel1 { get; set; }

    public int? cLogLevel2 { get; set; }

    public int? cLogLevel3 { get; set; }

    public int? cIdxLevel1 { get; set; }

    public int? cIdxLevel2 { get; set; }

    public int? cIdxLevel3 { get; set; }
}
