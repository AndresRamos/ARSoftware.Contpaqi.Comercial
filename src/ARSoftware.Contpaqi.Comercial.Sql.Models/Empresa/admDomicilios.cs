using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admDomicilios
{
    public int CIDDIRECCION { get; set; }

    public int CIDCATALOGO { get; set; }

    public int CTIPOCATALOGO { get; set; }

    public int CTIPODIRECCION { get; set; }

    public string CNOMBRECALLE { get; set; } = null!;

    public string CNUMEROEXTERIOR { get; set; } = null!;

    public string CNUMEROINTERIOR { get; set; } = null!;

    public string CCOLONIA { get; set; } = null!;

    public string CCODIGOPOSTAL { get; set; } = null!;

    public string CTELEFONO1 { get; set; } = null!;

    public string CTELEFONO2 { get; set; } = null!;

    public string CTELEFONO3 { get; set; } = null!;

    public string CTELEFONO4 { get; set; } = null!;

    public string CEMAIL { get; set; } = null!;

    public string CDIRECCIONWEB { get; set; } = null!;

    public string CPAIS { get; set; } = null!;

    public string CESTADO { get; set; } = null!;

    public string CCIUDAD { get; set; } = null!;

    public string CTEXTOEXTRA { get; set; } = null!;

    public string CTIMESTAMP { get; set; } = null!;

    public string CMUNICIPIO { get; set; } = null!;

    public string CSUCURSAL { get; set; } = null!;
}
