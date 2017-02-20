namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class nom10036
    {
        public bool? activa { get; set; }

        public int id { get; set; }

        [StringLength(30)]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        public string sentenciaSQL { get; set; }
    }
}