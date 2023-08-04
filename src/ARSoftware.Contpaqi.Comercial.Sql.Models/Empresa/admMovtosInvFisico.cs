using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMovtosInvFisico
{
    public int CIDMOVIMIENTO { get; set; }

    public int CIDPRODUCTO { get; set; }

    public int CIDALMACEN { get; set; }

    public int CIDUNIDAD { get; set; }

    public double CUNIDADES { get; set; }

    public double CUNIDADESNC { get; set; }

    public double CUNIDADESCAPTURADAS { get; set; }

    public int CMOVTOOCULTO { get; set; }

    public int CIDMOVTOOWNER { get; set; }
}
