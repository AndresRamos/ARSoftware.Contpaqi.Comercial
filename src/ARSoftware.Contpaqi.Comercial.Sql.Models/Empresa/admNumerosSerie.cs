using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admNumerosSerie
{
    public int CIDSERIE { get; set; }

    public int CIDPRODUCTO { get; set; }

    public string CNUMEROSERIE { get; set; } = null!;

    public int CIDALMACEN { get; set; }

    public int CESTADO { get; set; }

    public int CESTADOANTERIOR { get; set; }

    public string CNUMEROLOTE { get; set; } = null!;

    public DateTime CFECHACADUCIDAD { get; set; }

    public DateTime CFECHAFABRICACION { get; set; }

    public string CPEDIMENTO { get; set; } = null!;

    public string CADUANA { get; set; } = null!;

    public DateTime CFECHAPEDIMENTO { get; set; }

    public double CTIPOCAMBIO { get; set; }

    public double CCOSTO { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public int CNUMADUANA { get; set; }

    public string CCLAVESAT { get; set; } = null!;
}
