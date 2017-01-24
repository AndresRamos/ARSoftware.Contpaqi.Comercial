namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Plantillas
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

        public int? IdDocumentoDe { get; set; }

        [StringLength(30)]
        public string TipoDocumento { get; set; }

        [StringLength(100)]
        public string BeneficiarioPagador { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        public double? Total { get; set; }

        public bool? EsParaAbonoCta { get; set; }

        [StringLength(40)]
        public string CodigoPersona { get; set; }

        public int? NatBancaria { get; set; }

        public int? Naturaleza { get; set; }

        [StringLength(5)]
        public string CodigoMoneda { get; set; }
    }
}