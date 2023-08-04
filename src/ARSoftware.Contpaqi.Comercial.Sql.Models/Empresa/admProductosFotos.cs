using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admProductosFotos
{
    public int CIDFOTOPRODUCTO { get; set; }

    public string CNOMBREFOTOPRODUCTO { get; set; } = null!;

    public string? CFOTOPRODUCTO { get; set; }
}
