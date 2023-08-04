using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admAcumuladosTipos
{
    public int CIDTIPOACUMULADO { get; set; }

    public string CNOMBRE { get; set; } = null!;

    public int CTIPOOWNER1 { get; set; }

    public int CTIPOOWNER2 { get; set; }

    public int CTIPOACTUALIZACION { get; set; }

    public int CTIPOMONEDA { get; set; }
}
