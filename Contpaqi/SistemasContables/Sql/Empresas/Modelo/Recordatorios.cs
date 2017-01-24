namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Recordatorios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdDocumentoDe { get; set; }

        [Required]
        [StringLength(30)]
        public string TipoDocumento { get; set; }

        public int IdCuentaCheque { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public int IdUsuario { get; set; }

        [StringLength(100)]
        public string MensajeCorto { get; set; }

        [Column(TypeName = "ntext")]
        public string Mensaje { get; set; }

        public DateTime? Fecha { get; set; }
    }
}