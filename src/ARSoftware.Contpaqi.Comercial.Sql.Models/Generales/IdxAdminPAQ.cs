using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class IdxAdminPAQ
{
    public int CIDAUTOINCSQL { get; set; }

    public string TABLA { get; set; } = null!;

    public string NOMBRE { get; set; } = null!;

    public string TIPO { get; set; } = null!;

    public string GRUPO { get; set; } = null!;

    public string DESCRIPCIO { get; set; } = null!;

    public byte CASE { get; set; }

    public byte UNIQUE { get; set; }

    public byte DESCENDING { get; set; }
}
