namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ValoresAuxiliaresCV")]
    public partial class ValoresAuxiliaresCV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdClave { get; set; }

        public int IdEjercicio { get; set; }

        public int Periodo { get; set; }

        public double? Valor1 { get; set; }

        public double? Valor2 { get; set; }

        public double? Valor3 { get; set; }

        public double? Valor4 { get; set; }
    }
}