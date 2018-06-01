namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TiposDocumentos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(30)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public int? Modulo { get; set; }

        public int IdDocumentoDe { get; set; }

        public int? Naturaleza { get; set; }

        public int? NatBancaria { get; set; }

        public int? AfectaExistencia { get; set; }

        public int? TipoGeneracion { get; set; }

        [StringLength(5)]
        public string CodigoFolioTipoDocumento { get; set; }

        [StringLength(5)]
        public string CodigoFolioDocumentoDe { get; set; }

        [StringLength(5)]
        public string CodigoFolioDigital { get; set; }

        [StringLength(254)]
        public string FormaPreimpresa { get; set; }

        public int? MaximoMovimientos { get; set; }

        public int? Clasificacion { get; set; }

        public int? ContabilizarPor { get; set; }

        [StringLength(20)]
        public string CodigoPrepoliza { get; set; }

        public bool? AgruparMovtosBanco { get; set; }

        public bool? AgruparMovtosPoliza { get; set; }

        public bool? EsFiscal { get; set; }

        public bool? EsFolioDigital { get; set; }

        public bool? UsaAsignaNumero { get; set; }

        public bool? UsaAsignaSerieFolio { get; set; }

        public bool? PermiteEditarFolio { get; set; }
    }
}
