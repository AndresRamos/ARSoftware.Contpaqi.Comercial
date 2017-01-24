namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Listados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Consec { get; set; }

        public int? Modulo { get; set; }

        [StringLength(30)]
        public string Titulo { get; set; }

        public int? Usuario { get; set; }

        public int? Alcance { get; set; }

        [StringLength(30)]
        public string NombreTabla { get; set; }

        public int? ColumnaOrden { get; set; }

        public bool? Ascendente { get; set; }

        public bool? ConsultaInicial { get; set; }

        [Column(TypeName = "ntext")]
        public string DatosXML { get; set; }
    }
}