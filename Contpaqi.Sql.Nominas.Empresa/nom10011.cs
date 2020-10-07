namespace Contpaqi.Sql.Nominas.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nom10011
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idempleado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idtipoacumulado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ejercicio { get; set; }

        public double? importe1 { get; set; }

        public double? importe2 { get; set; }

        public double? importe3 { get; set; }

        public double? importe4 { get; set; }

        public double? importe5 { get; set; }

        public double? importe6 { get; set; }

        public double? importe7 { get; set; }

        public double? importe8 { get; set; }

        public double? importe9 { get; set; }

        public double? importe10 { get; set; }

        public double? importe11 { get; set; }

        public double? importe12 { get; set; }

        public double? importeinicioejercicio { get; set; }

        public double? importeejercicioanterior { get; set; }
    }
}
