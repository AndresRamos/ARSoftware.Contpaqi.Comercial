namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SaldosCtasCheques
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdCuentaCheque { get; set; }

        public int Ejercicio { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo { get; set; }

        public double? SaldoInicial { get; set; }

        public double? Saldo1 { get; set; }

        public double? Saldo2 { get; set; }

        public double? Saldo3 { get; set; }

        public double? Saldo4 { get; set; }

        public double? Saldo5 { get; set; }

        public double? Saldo6 { get; set; }

        public double? Saldo7 { get; set; }

        public double? Saldo8 { get; set; }

        public double? Saldo9 { get; set; }

        public double? Saldo10 { get; set; }

        public double? Saldo11 { get; set; }

        public double? Saldo12 { get; set; }

        public double? Saldo13 { get; set; }

        public double? Saldo14 { get; set; }
    }
}
