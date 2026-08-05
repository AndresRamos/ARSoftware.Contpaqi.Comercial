using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admSegmentosImpuestos
{
    public int CIDSEGMENTO { get; set; }

    public int CTIPO { get; set; }

    public int CCATALOGO { get; set; }

    public double CTASAMIN { get; set; }

    public double CTASAMAX { get; set; }

    public string CSEGMENTO1 { get; set; } = null!;

    public string CSEGMENTO2 { get; set; } = null!;

    public string CSEGMENTO3 { get; set; } = null!;

    public string CTIMESTAMP { get; set; } = null!;
}
