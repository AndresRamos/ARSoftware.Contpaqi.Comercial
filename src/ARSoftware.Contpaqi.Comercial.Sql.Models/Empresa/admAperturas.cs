using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAperturas
{
    public int CIDAPERTURA { get; set; }

    public int CIDCAJA { get; set; }

    public int CIDAGENTE { get; set; }

    public string? CUSUARIO { get; set; }

    public string CTERMINAL { get; set; } = null!;

    public int CESTADO { get; set; }

    public DateTime CFECHAAPERTURA { get; set; }

    public string CHORAAPERTURA { get; set; } = null!;

    public DateTime CFECHACORTE { get; set; }

    public string CHORACORTE { get; set; } = null!;

    public DateTime CFECHAFACTURA { get; set; }

    public int CIDFACTURA { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
