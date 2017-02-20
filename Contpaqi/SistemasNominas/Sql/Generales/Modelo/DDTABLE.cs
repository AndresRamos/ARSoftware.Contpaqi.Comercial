namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DDTABLE")]
    public partial class DDTABLE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string databasename { get; set; }

        [StringLength(50)]
        public string group { get; set; }

        [StringLength(50)]
        public string tablealias { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string tablename { get; set; }
    }
}