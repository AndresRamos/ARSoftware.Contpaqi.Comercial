namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Monedas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(3)]
        public string Simbolo { get; set; }

        public int? PosicionSimbolo { get; set; }

        public int? Decimales { get; set; }

        [StringLength(30)]
        public string NombreSingular { get; set; }

        [StringLength(30)]
        public string NombrePlural { get; set; }

        [StringLength(30)]
        public string TextoFinal { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}
