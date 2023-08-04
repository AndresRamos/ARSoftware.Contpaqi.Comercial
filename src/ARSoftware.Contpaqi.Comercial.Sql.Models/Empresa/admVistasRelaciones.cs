using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admVistasRelaciones
{
    public int CIDRELACION { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CIDIDIOMA { get; set; }

    public string CNOMBRENATIVOTABLA1 { get; set; } = null!;

    public string CNOMBRENATIVOTABLA2 { get; set; } = null!;

    public string CNOMBRERELACION { get; set; } = null!;

    public string CSENTENCIAENLACE { get; set; } = null!;

    public string CCAMPONA01 { get; set; } = null!;

    public string CFILTRO { get; set; } = null!;

    public string CTABLAREL1 { get; set; } = null!;

    public string CTABLAREL2 { get; set; } = null!;

    public string CFILTROAUX { get; set; } = null!;
}
