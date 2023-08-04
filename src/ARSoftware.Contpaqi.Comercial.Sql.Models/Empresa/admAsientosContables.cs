using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAsientosContables
{
    public int CIDASIENTOCONTABLE { get; set; }

    public string CNUMEROASIENTOCONTABLE { get; set; } = null!;

    public string CNOMBREASIENTOCONTABLE { get; set; } = null!;

    public int CFRECUENCIA { get; set; }

    public int CORIGENFECHA { get; set; }

    public int CTIPOPOLIZA { get; set; }

    public int CORIGENNUMERO { get; set; }

    public int CORIGENCONCEPTO { get; set; }

    public string CCONCEPTO { get; set; } = null!;

    public string CDIARIO { get; set; } = null!;

    public string CTIMESTAMP { get; set; } = null!;
}
