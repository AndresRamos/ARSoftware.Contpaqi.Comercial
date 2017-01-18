namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Cuentas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string NomIdioma { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        public bool? EsBaja { get; set; }

        public int? CtaMayor { get; set; }

        public bool? CtaEfectivo { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? SistOrigen { get; set; }

        public int? IdMoneda { get; set; }

        public int? DigAgrup { get; set; }

        public int? IdSegNeg { get; set; }

        public bool? SegNegMovtos { get; set; }

        public int? Afectable { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int? IdRubro { get; set; }

        public int? Consume { get; set; }

        public int? IdAgrupadorSAT { get; set; }
    }
}
