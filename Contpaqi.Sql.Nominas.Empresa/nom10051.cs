namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10051
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTablaPrestacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Antiguedad { get; set; }

        public double DiasVacaciones { get; set; }

        public double DiasAguinaldo { get; set; }

        public double PorcentajePrima { get; set; }

        public double DiasAntiguedad { get; set; }

        public double FactorIntegracion { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
