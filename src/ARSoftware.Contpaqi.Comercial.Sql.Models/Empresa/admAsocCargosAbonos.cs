using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAsocCargosAbonos
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDDOCUMENTOABONO { get; set; }

    public int CIDDOCUMENTOCARGO { get; set; }

    public double CIMPORTEABONO { get; set; }

    public double CIMPORTECARGO { get; set; }

    public DateTime CFECHAABONOCARGO { get; set; }

    public int CIDDESCUENTOPRONTOPAGO { get; set; }

    public int CIDUTILIDADPERDIDACAMB { get; set; }

    public int CIDAJUSIVA { get; set; }
}
