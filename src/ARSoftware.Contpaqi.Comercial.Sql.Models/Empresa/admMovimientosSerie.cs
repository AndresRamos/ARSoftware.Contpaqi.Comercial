using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovimientosSerie
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDMOVIMIENTO { get; set; }

    public int CIDSERIE { get; set; }

    public DateTime CFECHA { get; set; }
}
