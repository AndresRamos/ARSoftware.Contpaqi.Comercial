using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAsocBuzones
{
    public int CTIPOCATALOGO { get; set; }

    public int CIDCATALOGO { get; set; }

    public string CINBOXID { get; set; } = null!;

    public string? CPRIVATEPEMKEY { get; set; }

    public string? CPUBLICPEMKEY { get; set; }

    public string CPASSWORD { get; set; } = null!;
}
