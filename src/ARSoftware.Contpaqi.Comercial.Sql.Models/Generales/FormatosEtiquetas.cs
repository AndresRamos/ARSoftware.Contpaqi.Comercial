using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class FormatosEtiquetas
{
    public int CIDTIPOHOJA { get; set; }

    public string CNOMBREHOJA { get; set; } = null!;

    public double CLARGOPAPEL { get; set; }

    public double CANCHOPAPEL { get; set; }

    public double CMARGENIZQUIERDO { get; set; }

    public double CMARGENDERECHO { get; set; }

    public double CMARGENINFERIOR { get; set; }

    public double CMARGENSUPERIOR { get; set; }

    public int CNUMETIQUETAS { get; set; }

    public int CNUMRENGLONES { get; set; }
}
