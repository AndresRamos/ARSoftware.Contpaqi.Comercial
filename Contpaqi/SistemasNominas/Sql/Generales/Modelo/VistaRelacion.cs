namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VistaRelacion")]
    public partial class VistaRelacion
    {
        [StringLength(30)]
        public string campo { get; set; }

        [StringLength(30)]
        public string campodestino { get; set; }

        public int id { get; set; }

        public int? idtabla { get; set; }

        public int? idtabladestino { get; set; }
    }
}