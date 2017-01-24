namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Bancos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        [StringLength(254)]
        public string Logotipo { get; set; }

        [StringLength(250)]
        public string PaginaWeb { get; set; }

        [StringLength(5)]
        public string ClaveFiscal { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}