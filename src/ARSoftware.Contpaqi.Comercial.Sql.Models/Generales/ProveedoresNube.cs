using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class ProveedoresNube
{
    public int CIDPROVEEDORSERVICIO { get; set; }

    public string CNOMBREPROVEEDOR { get; set; } = null!;

    public int CTIPOPROVEEDOR { get; set; }

    public int CACTIVO { get; set; }

    public string CURLBASE { get; set; } = null!;
}
