namespace Contpaqi.SistemasContables.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PermisosUsuario")]
    public partial class PermisosUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdUsuario { get; set; }

        public int IdProceso { get; set; }

        public int Permisos { get; set; }

        public int? Uso { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
