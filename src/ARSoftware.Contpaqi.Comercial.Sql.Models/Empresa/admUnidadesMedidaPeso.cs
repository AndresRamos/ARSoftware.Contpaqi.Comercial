using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admUnidadesMedidaPeso
{
    public int CIDUNIDAD { get; set; }

    public string CNOMBREUNIDAD { get; set; } = null!;

    public string CABREVIATURA { get; set; } = null!;

    public string CDESPLIEGUE { get; set; } = null!;

    public string CCLAVEINT { get; set; } = null!;

    public string CCLAVESAT { get; set; } = null!;
}
