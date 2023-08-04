using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class admVistasRelaciones
{
    public int CIDRELACION { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CINDICEIDIOMA { get; set; }

    public string CNOMBRENATIVOTABLA1 { get; set; } = null!;

    public string CNOMBRENATIVOTABLA2 { get; set; } = null!;

    public string CNOMBRERELACION { get; set; } = null!;

    public string CSENTENCIAENLACE { get; set; } = null!;
}
