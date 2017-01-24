namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ClavesCV")]
    public partial class ClavesCV
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int TipoClave { get; set; }

        public int Consec { get; set; }

        [Required]
        [StringLength(20)]
        public string Clave { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? IdCuenta { get; set; }
    }
}