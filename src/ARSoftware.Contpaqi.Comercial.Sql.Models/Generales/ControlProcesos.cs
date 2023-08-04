using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class ControlProcesos
{
    public string cGuidControl { get; set; } = null!;

    public string? cProcesoDescripcion { get; set; }

    public int? cPorcentaje { get; set; }

    public DateTime? cFechaInicial { get; set; }

    public DateTime? cFechaFinal { get; set; }

    public int? cTotalExtraccion { get; set; }

    public int? cTotalProcesado { get; set; }

    public string? cNombreLog { get; set; }

    public string? cEstatusProceso { get; set; }
}
