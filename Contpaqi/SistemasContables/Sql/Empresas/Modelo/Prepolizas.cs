namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Prepolizas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(52)]
        public string TipoPol { get; set; }

        [StringLength(52)]
        public string Folio { get; set; }

        public int? Clase { get; set; }

        [StringLength(100)]
        public string Concepto { get; set; }

        [StringLength(52)]
        public string Diario { get; set; }

        [StringLength(52)]
        public string CveFecha { get; set; }

        public int? DiaDelMes { get; set; }

        [StringLength(1)]
        public string Acceso { get; set; }

        [StringLength(254)]
        public string EsquemaDatos { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int? SistOrig { get; set; }

        [StringLength(15)]
        public string Variable1 { get; set; }

        [StringLength(15)]
        public string Variable2 { get; set; }

        [StringLength(15)]
        public string Variable3 { get; set; }

        [StringLength(15)]
        public string Variable4 { get; set; }

        [StringLength(15)]
        public string Variable5 { get; set; }

        [StringLength(15)]
        public string Variable6 { get; set; }

        [StringLength(15)]
        public string Variable7 { get; set; }

        [StringLength(15)]
        public string Variable8 { get; set; }

        [StringLength(15)]
        public string Variable9 { get; set; }

        [StringLength(15)]
        public string Variable10 { get; set; }
    }
}
