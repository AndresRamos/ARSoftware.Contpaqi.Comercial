namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NombresValoresCV")]
    public partial class NombresValoresCV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int NumValor { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }
    }
}
