using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admPreciosCompra
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDPRODUCTO { get; set; }

    public int CIDPROVEEDOR { get; set; }

    public double CPRECIOCOMPRA { get; set; }

    public int CIDMONEDA { get; set; }

    public string CCODIGOPRODUCTOPROVEEDOR { get; set; } = null!;

    public int CIDUNIDAD { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
