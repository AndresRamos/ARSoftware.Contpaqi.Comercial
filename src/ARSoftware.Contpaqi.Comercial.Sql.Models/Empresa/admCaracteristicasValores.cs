using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admCaracteristicasValores
{
    public int CIDVALORCARACTERISTICA { get; set; }

    public int CIDPADRECARACTERISTICA { get; set; }

    public string CVALORCARACTERISTICA { get; set; } = null!;

    public string CNEMOCARACTERISTICA { get; set; } = null!;
}
