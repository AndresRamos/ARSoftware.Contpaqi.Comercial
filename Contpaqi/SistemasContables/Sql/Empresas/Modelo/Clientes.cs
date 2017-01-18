namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(40)]
        public string Codigo { get; set; }

        [StringLength(40)]
        public string CodigoPersona { get; set; }

        [StringLength(30)]
        public string CodigoCuenta { get; set; }

        [StringLength(30)]
        public string CodigoCtaComplementaria { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public int? IdSegNeg { get; set; }
    }
}
