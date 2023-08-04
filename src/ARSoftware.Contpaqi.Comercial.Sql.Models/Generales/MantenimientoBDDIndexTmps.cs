using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;

public partial class MantenimientoBDDIndexTmps
{
    public string cNombreTabla { get; set; } = null!;

    public string cNombreIndex { get; set; } = null!;

    public int? cPorcentajeFragmentacion { get; set; }
}
