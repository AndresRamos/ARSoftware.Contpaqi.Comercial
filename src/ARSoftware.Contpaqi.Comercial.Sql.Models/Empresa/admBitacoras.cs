using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admBitacoras
{
    public int IDBITACORA { get; set; }

    public DateTime FECHA { get; set; }

    public string HORA { get; set; } = null!;

    public string USUARIO { get; set; } = null!;

    public string NOMBRE { get; set; } = null!;

    public string USUARIO2 { get; set; } = null!;

    public string NOMBRE2 { get; set; } = null!;

    public string PROCESO { get; set; } = null!;

    public string DATOS { get; set; } = null!;

    public int IDSISTEMA { get; set; }

    public string CTEXTOEX01 { get; set; } = null!;

    public string CTEXTOEX02 { get; set; } = null!;

    public string CTEXTOEX03 { get; set; } = null!;

    public DateTime CFECHAEX01 { get; set; }

    public double CIMPORTE01 { get; set; }

    public double CIMPORTE02 { get; set; }

    public double CIMPORTE03 { get; set; }
}
