namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Categorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string CodigoMoneda { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(1)]
        public string Presupuesto { get; set; }

        [StringLength(30)]
        public string CodigoCuenta { get; set; }

        [StringLength(30)]
        public string CodigoCtaComplementaria { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public int? IdSegNeg { get; set; }

        public int? IdDatoExtra { get; set; }

        [StringLength(1)]
        public string Nivel { get; set; }

        [StringLength(30)]
        public string SegmentoCuenta { get; set; }
    }
}