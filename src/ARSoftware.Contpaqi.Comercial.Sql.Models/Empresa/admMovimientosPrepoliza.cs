using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovimientosPrepoliza
{
    public int CIDMOVIMIENTOPREPOLIZA { get; set; }

    public int CIDPREPOLIZA { get; set; }

    public int EJE { get; set; }

    public int PERIODO { get; set; }

    public int TIPOPOL { get; set; }

    public int NUMPOL { get; set; }

    public int MOVTO { get; set; }

    public string CUENTA { get; set; } = null!;

    public int TIPOMOV { get; set; }

    public string REFERENCIA { get; set; } = null!;

    public double IMPORTE { get; set; }

    public string DIARIO { get; set; } = null!;

    public double MONEDA { get; set; }

    public string CONCEPTO { get; set; } = null!;

    public DateTime FECHA { get; set; }

    public string SEGNEG { get; set; } = null!;
}
