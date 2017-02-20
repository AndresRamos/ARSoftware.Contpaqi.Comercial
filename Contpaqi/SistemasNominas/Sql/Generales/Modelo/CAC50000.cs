namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CAC50000
    {
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Grupo { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdSistema { get; set; }
    }
}