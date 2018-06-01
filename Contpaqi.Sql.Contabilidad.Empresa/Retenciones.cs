namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Retenciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime? FechaExpedicion { get; set; }

        public int? MesInicialPeriodo { get; set; }

        public int? MesFinalPeriodo { get; set; }

        public int? EjercicioPeriodo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Referencia { get; set; }

        public int IdBeneficiario { get; set; }

        public int IdComplemento { get; set; }

        public double? TotalMontoOperacion { get; set; }

        public double? TotalGravado { get; set; }

        public double? TotalExento { get; set; }

        public double? TotalRetenciones { get; set; }

        [Column(TypeName = "ntext")]
        public string XMLComplemento { get; set; }

        public int? Estado { get; set; }

        [StringLength(36)]
        public string FolioCancelacion { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }

        [StringLength(36)]
        public string GuidRetencion { get; set; }

        [StringLength(36)]
        public string UUIDRetencion { get; set; }
    }
}
