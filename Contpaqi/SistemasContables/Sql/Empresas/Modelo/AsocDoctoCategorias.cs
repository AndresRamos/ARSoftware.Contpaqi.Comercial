namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AsocDoctoCategorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdDocumento { get; set; }

        public int IdDocumentoDe { get; set; }

        [StringLength(30)]
        public string TipoDocumento { get; set; }

        public int? IdCuentaCheque { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        public int IdCategoria { get; set; }

        public int IdSubCategoria { get; set; }

        public double? Porcentaje { get; set; }

        public double? Total { get; set; }
    }
}
