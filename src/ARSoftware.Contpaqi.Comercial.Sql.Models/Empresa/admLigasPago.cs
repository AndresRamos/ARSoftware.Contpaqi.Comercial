using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admLigasPago
{
    public int CIDLIGA { get; set; }

    public int CIDCLIENTEPROVEEDOR { get; set; }

    public int CIDMONEDA { get; set; }

    public int CIDPROVEEDORSERVICIO { get; set; }

    public DateTime CFECHAINIVIG { get; set; }

    public DateTime CFECHAFINVIG { get; set; }

    public DateTime CFECHAPAGO { get; set; }

    public int CESTADO { get; set; }

    public int CTIPOPAGO { get; set; }

    public string? CLIGA { get; set; }

    public string CGUIDEXTERNALREF { get; set; } = null!;

    public string CGUIDLIGA { get; set; } = null!;

    public int CIDDOCTOABONO { get; set; }

    public double CTOTAL { get; set; }
}
