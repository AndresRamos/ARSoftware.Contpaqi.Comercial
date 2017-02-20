namespace Contpaqi.SistemasNominas.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Nom10046
    {
        public bool Calculado { get; set; }

        [Required]
        [StringLength(200)]
        public string ConceptosCalculo { get; set; }

        [Required]
        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime FechaBaja { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEmpleado { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFiniquito { get; set; }

        public int idPeriodo { get; set; }

        [Required]
        [StringLength(100)]
        public string ParametrosGenerales { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}