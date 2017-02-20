namespace Contpaqi.SistemasNominas.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CAC30000
    {
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdSistema { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Perfil { get; set; }
    }
}