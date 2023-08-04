using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admDocumentosModelosBack
{
    public int CIDDOCUMENTODE { get; set; }

    public string CDESCRIPCION { get; set; } = null!;

    public int CNATURALEZA { get; set; }

    public int CAFECTAEXISTENCIA { get; set; }

    public int CMODULO { get; set; }

    public double CNOFOLIO { get; set; }

    public int CIDCONCEPTODOCTOASUMIDO { get; set; }

    public int CUSACLIENTE { get; set; }

    public int CUSAPROVEEDOR { get; set; }

    public int CIDASIENTOCONTABLE { get; set; }
}
