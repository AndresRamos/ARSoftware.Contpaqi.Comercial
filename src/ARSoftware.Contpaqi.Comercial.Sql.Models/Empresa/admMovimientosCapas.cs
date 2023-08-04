using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovimientosCapas
{
    public int CIDAUTOINCSQL { get; set; }

    public int CIDMOVIMIENTO { get; set; }

    public int CIDCAPA { get; set; }

    public DateTime CFECHA { get; set; }

    public double CUNIDADES { get; set; }

    public int CTIPOCAPA { get; set; }

    public int CIDUNIDAD { get; set; }
}
