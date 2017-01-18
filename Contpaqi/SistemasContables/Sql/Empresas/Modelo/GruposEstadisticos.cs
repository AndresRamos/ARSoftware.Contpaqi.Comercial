namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class GruposEstadisticos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        public int PosSeg { get; set; }

        public int? LongSeg { get; set; }

        [Required]
        [StringLength(30)]
        public string Patron { get; set; }

        [Required]
        [StringLength(30)]
        public string CuentaDel { get; set; }

        [Required]
        [StringLength(30)]
        public string CuentaAl { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
