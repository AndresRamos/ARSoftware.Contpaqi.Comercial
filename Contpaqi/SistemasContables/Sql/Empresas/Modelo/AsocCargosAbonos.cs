namespace Contpaqi.SistemasContables.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AsocCargosAbonos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int? IdDocumento { get; set; }

        public int IdDocumentoDe { get; set; }

        [Required]
        [StringLength(30)]
        public string TipoDocumento { get; set; }

        public int IdCuentaCheques { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        [Required]
        [StringLength(30)]
        public string CodigoConceptoPago { get; set; }

        [Required]
        [StringLength(15)]
        public string SeriePago { get; set; }

        [Required]
        [StringLength(20)]
        public string FolioPago { get; set; }

        public double? ImportePago { get; set; }

        public DateTime? FechaPago { get; set; }

        [StringLength(100)]
        public string ConceptoPago { get; set; }

        [StringLength(30)]
        public string CodigoClienteProveedor { get; set; }

        [StringLength(100)]
        public string ClienteProveedor { get; set; }

        public bool? EsCFD { get; set; }

        public double? SaldoCargoAbono { get; set; }

        public bool? EsDisponibleDoctoBancario { get; set; }

        public int IdCheque { get; set; }

        public int IdEgreso { get; set; }

        public int IdIngreso { get; set; }

        public int IdIngresoNoDepositado { get; set; }

        public DateTime Fecha { get; set; }
    }
}