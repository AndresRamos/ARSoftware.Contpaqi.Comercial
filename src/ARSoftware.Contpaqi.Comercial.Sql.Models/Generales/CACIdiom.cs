using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class CACIdiom
{
    public int CIDAUTOINCSQL { get; set; }

    public int NUMEROSISTEMA { get; set; }

    public int NUMEROIDIOMA { get; set; }

    public string NOMBREIDIOMA { get; set; } = null!;

    public string NOMBREDLLAPP { get; set; } = null!;

    public string NOMBREDLLERR { get; set; } = null!;

    public string ARCHBDD { get; set; } = null!;

    public string ARCHAYUDA { get; set; } = null!;

    public int IDAYUDA { get; set; }
}
