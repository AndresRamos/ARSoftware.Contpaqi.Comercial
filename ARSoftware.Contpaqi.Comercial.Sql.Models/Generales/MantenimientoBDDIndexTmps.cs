using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Generales
{
    public partial class MantenimientoBDDIndexTmps
    {
        public string cNombreTabla { get; set; }
        public string cNombreIndex { get; set; }
        public int? cPorcentajeFragmentacion { get; set; }
    }
}
