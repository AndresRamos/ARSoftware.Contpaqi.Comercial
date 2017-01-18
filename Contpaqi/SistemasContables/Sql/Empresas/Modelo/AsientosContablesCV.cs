namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AsientosContablesCV")]
    public partial class AsientosContablesCV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Consec { get; set; }

        public int? IdClave { get; set; }

        public int? IdCuenta { get; set; }

        public bool? TipoMovto { get; set; }

        public int? ClaveImp { get; set; }

        public double? Importe { get; set; }

        public int? RefMovto { get; set; }

        [StringLength(30)]
        public string Referencia { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        public int? IdDiario { get; set; }

        public int? IdSegNeg { get; set; }
    }
}
