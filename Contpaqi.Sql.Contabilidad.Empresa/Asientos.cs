namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asientos
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

        public int? Frecuencia { get; set; }

        public int? Fecha { get; set; }

        public int? Tipo { get; set; }

        public int? Concepto { get; set; }

        [StringLength(100)]
        public string DescripcionConcepto { get; set; }

        [StringLength(20)]
        public string AsientoDe { get; set; }

        public int? TipoXML { get; set; }

        public int? IdDiario { get; set; }

        public bool? CrearPolizasSinAfectar { get; set; }

        public bool? SuprimirMovtosEnCero { get; set; }

        public int? IdCtaBancaria { get; set; }

        public bool? CrearDoctoBancario { get; set; }

        public bool? EsBaja { get; set; }

        public bool? CrearPoliza { get; set; }

        [StringLength(20)]
        public string TipoCFDI { get; set; }

        public bool? EsGasto { get; set; }
    }
}
