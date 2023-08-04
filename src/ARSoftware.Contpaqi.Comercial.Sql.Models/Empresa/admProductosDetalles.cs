using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admProductosDetalles
{
    public int CIDPRODUCTO { get; set; }

    public int CTIPOPRODUCTO { get; set; }

    public int CIDPRODUCTOPADRE { get; set; }

    public int CIDVALORCARACTERISTICA1 { get; set; }

    public int CIDVALORCARACTERISTICA2 { get; set; }

    public int CIDVALORCARACTERISTICA3 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
