using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class MantenimientoBDDErrores
{
    public string cGuidProceso { get; set; } = null!;

    public string cAliasBDD { get; set; } = null!;

    public string? cDescripcionError { get; set; }
}
