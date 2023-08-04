using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class Empresas
{
    public int CIDEMPRESA { get; set; }

    public string CNOMBREEMPRESA { get; set; } = null!;

    public string CRUTADATOS { get; set; } = null!;

    public string CRUTARESPALDOS { get; set; } = null!;
}
