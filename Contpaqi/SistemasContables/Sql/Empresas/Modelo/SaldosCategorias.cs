namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SaldosCategorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdCategoria { get; set; }

        public int Ejercicio { get; set; }

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
