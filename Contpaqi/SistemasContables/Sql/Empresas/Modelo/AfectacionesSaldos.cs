namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AfectacionesSaldos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int NumTransac { get; set; }

        public int? IdEmpresa { get; set; }

        public int? IdCuenta { get; set; }

        [StringLength(1)]
        public string TipoAnt { get; set; }

        [StringLength(1)]
        public string TipoNvo { get; set; }

        public int? IdCtaSupAnt { get; set; }

        public int? IdCtaSupNva { get; set; }

        public int? Estado { get; set; }

        public int? MotivoError { get; set; }

        public bool? CtaSupEsAfectable { get; set; }

        public bool? Afectar { get; set; }
    }
}