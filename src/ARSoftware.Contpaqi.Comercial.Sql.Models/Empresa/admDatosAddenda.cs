using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admDatosAddenda
{
    public int CIDAUTOINCSQL { get; set; }

    public int IDADDENDA { get; set; }

    public int TIPOCAT { get; set; }

    public int IDCAT { get; set; }

    public int NUMCAMPO { get; set; }

    public string VALOR { get; set; } = null!;
}
