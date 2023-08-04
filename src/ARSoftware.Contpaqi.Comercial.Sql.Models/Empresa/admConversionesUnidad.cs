using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admConversionesUnidad
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDUNIDAD1 { get; set; }

    public int CIDUNIDAD2 { get; set; }

    public double CFACTORCONVERSION { get; set; }

    public string CEXPRESIONFACTOR { get; set; } = null!;
}
