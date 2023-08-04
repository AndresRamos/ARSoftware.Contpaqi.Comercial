using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class admVistasTablas
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CIDIDIOMA { get; set; }

    public int CIDMODULO { get; set; }

    public string CNOMBRENATIVOTABLA { get; set; } = null!;

    public string CNOMBREAMIGABLETABLA { get; set; } = null!;
}
