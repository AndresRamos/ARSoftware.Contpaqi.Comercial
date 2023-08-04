using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class admVistasPorModulo
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDMODULO { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CIDIDIOMA { get; set; }

    public string CNOMBREMODULO { get; set; } = null!;
}
