using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class ModelosFinancieros
{
    public int CIDMODELO { get; set; }

    public int CIDSISTEMA { get; set; }

    public string CDESCRIPCION { get; set; } = null!;

    public string CRUTA { get; set; } = null!;
}
