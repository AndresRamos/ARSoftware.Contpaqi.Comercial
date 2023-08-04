using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admClasificacionesValores
{
    public int CIDVALORCLASIFICACION { get; set; }

    public string CVALORCLASIFICACION { get; set; } = null!;

    public int CIDCLASIFICACION { get; set; }

    public string CCODIGOVALORCLASIFICACION { get; set; } = null!;

    public string CSEGCONT1 { get; set; } = null!;

    public string CSEGCONT2 { get; set; } = null!;

    public string CSEGCONT3 { get; set; } = null!;
}
