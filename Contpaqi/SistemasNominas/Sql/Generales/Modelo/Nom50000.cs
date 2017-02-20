namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Nom50000
    {
        [StringLength(40)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroColumna { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroTabla { get; set; }

        [StringLength(1)]
        public string TipoColumna { get; set; }
    }
}