using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class EmpresasModelo
{
    public int CIDEMPRESA { get; set; }

    public string CNOMBREEMPRESA { get; set; } = null!;

    public string CRUTAARCHIVOS { get; set; } = null!;
}
