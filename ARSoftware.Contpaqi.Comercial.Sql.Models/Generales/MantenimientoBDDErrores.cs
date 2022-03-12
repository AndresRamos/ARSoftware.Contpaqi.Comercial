using System;
using System.Collections.Generic;

namespace Contpaqi.Comercial.Sql.Models.Generales
{
    public partial class MantenimientoBDDErrores
    {
        public string cGuidProceso { get; set; }
        public string cAliasBDD { get; set; }
        public string cDescripcionError { get; set; }
    }
}
