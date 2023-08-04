using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admTiposCambio
{
    public int CIDTIPOCAMBIO { get; set; }

    public int CIDMONEDA { get; set; }

    public DateTime CFECHA { get; set; }

    public double CIMPORTE { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
