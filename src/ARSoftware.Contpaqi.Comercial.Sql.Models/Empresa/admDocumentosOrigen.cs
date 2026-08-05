using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admDocumentosOrigen
{
    public int CIDDOCUMENTO { get; set; }

    public string CSERIE { get; set; } = null!;

    public double CFOLIO { get; set; }

    public DateTime CFECHA { get; set; }
}
