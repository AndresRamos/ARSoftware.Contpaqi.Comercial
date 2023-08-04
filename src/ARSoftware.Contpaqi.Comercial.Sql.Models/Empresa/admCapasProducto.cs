using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admCapasProducto
{
    public int CIDCAPA { get; set; }

    public int CIDALMACEN { get; set; }

    public int CIDPRODUCTO { get; set; }

    public DateTime CFECHA { get; set; }

    public int CTIPOCAPA { get; set; }

    public string CNUMEROLOTE { get; set; } = null!;

    public DateTime CFECHACADUCIDAD { get; set; }

    public DateTime CFECHAFABRICACION { get; set; }

    public string CPEDIMENTO { get; set; } = null!;

    public string CADUANA { get; set; } = null!;

    public DateTime CFECHAPEDIMENTO { get; set; }

    public double CTIPOCAMBIO { get; set; }

    public double CEXISTENCIA { get; set; }

    public double CCOSTO { get; set; }

    public int CIDCAPAORIGEN { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public int CNUMADUANA { get; set; }

    public string CCLAVESAT { get; set; } = null!;
}
