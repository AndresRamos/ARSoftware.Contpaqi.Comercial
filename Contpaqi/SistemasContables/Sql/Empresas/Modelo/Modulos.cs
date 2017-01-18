namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Modulos
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

        public DateTime? FechaRegistro { get; set; }
    }
}
