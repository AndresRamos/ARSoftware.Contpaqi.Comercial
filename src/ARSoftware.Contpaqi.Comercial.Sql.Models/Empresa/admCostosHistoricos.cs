using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admCostosHistoricos
{
    public int CIDCOSTOH { get; set; }

    public int CIDPRODUCTO { get; set; }

    public int CIDALMACEN { get; set; }

    public DateTime CFECHACOSTOH { get; set; }

    public double CCOSTOH { get; set; }

    public double CULTIMOCOSTOH { get; set; }

    public int CIDMOVIMIENTO { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
