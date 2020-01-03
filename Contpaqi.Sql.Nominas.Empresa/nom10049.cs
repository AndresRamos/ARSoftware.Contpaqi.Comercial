namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10049
    {
        [Key]
        public int IDRelacion { get; set; }

        public int IDEmpleado { get; set; }

        public int IDContratante { get; set; }

        public double PorcentajeTiempo { get; set; }
    }
}
