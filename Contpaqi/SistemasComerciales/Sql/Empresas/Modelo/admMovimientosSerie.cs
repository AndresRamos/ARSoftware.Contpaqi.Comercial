namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admMovimientosSerie")]
    public partial class admMovimientosSerie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDMOVIMIENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDSERIE { get; set; }

        public DateTime CFECHA { get; set; }
    }
}
