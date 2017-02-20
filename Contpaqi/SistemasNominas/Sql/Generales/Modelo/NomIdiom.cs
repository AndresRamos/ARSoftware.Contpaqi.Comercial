namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NomIdiom")]
    public partial class NomIdiom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(30)]
        public string Nombre { get; set; }

        public int? Numero { get; set; }
    }
}