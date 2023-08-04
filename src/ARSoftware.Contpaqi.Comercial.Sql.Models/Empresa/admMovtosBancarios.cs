using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovtosBancarios
{
    public string CTRANSACTIONID { get; set; } = null!;

    public string CACCOUNTID { get; set; } = null!;

    public int CIDCUENTA { get; set; }

    public int CIDDOCUMENTO { get; set; }

    public DateTime CFECHA { get; set; }

    public string CDESCRIPCION { get; set; } = null!;

    public string CREFERENCIA { get; set; } = null!;

    public double CIMPORTE { get; set; }

    public int CESTADO { get; set; }

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CTIMESTAMP { get; set; } = null!;
}
