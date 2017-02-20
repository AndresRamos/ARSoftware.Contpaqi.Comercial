namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Asc10002
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string DatabaseName { get; set; }

        [StringLength(50)]
        public string FieldAlias { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FieldName { get; set; }

        [StringLength(1)]
        public string Index { get; set; }

        public bool NullIndex { get; set; }

        public bool RequiredField { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TableName { get; set; }

        public bool UserField { get; set; }
    }
}