namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admConversionesUnidad")]
    public partial class admConversionesUnidad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUNIDAD1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDUNIDAD2 { get; set; }

        public double CFACTORCONVERSION { get; set; }
    }
}
