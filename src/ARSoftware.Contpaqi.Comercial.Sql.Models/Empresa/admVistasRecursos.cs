using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admVistasRecursos
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CIDIDIOMA { get; set; }

    public int CIDMODULO { get; set; }

    public string CTABLABASE { get; set; } = null!;

    public string CTABLARELA { get; set; } = null!;

    public string CCAMPOBASE { get; set; } = null!;

    public string CCAMPOID { get; set; } = null!;

    public string CTITULO0 { get; set; } = null!;

    public string CCAMPO0 { get; set; } = null!;

    public string CINDICE0 { get; set; } = null!;

    public int CANCHO0 { get; set; }

    public string CTITULO1 { get; set; } = null!;

    public string CCAMPO1 { get; set; } = null!;

    public string CINDICE1 { get; set; } = null!;

    public int CANCHO1 { get; set; }

    public string CRANGO { get; set; } = null!;
}
