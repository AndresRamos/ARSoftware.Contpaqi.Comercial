namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DDFIELD")]
    public partial class DDFIELD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string databasename { get; set; }

        [StringLength(50)]
        public string displayformat { get; set; }

        [StringLength(50)]
        public string fieldalias { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string fieldname { get; set; }

        public bool searchable { get; set; }

        public bool selectable { get; set; }

        public bool sortable { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string tablename { get; set; }
    }
}