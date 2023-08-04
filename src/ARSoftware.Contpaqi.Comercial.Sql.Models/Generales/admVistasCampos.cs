using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class admVistasCampos
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDSISTEMA { get; set; }

    public int CIDIDIOMA { get; set; }

    public int CIDMODULO { get; set; }

    public string CNOMBRENATIVOTABLA { get; set; } = null!;

    public string CNOMBRENATIVOCAMPO { get; set; } = null!;

    public string CNOMBREAMIGABLECAMPO { get; set; } = null!;

    public int CANCHOCA01 { get; set; }

    public int CCAMPOOC01 { get; set; }

    public int CCAMPOOR01 { get; set; }

    public int CTIPOCAMPO { get; set; }

    public int CCALCULADO { get; set; }

    public int CDECIMALES { get; set; }

    public int CALINEAR { get; set; }

    public int CFORMATEAR { get; set; }
}
