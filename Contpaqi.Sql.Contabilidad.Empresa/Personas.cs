namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(40)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? EsCliente { get; set; }

        public bool? EsProveedor { get; set; }

        public bool? EsEmpleado { get; set; }

        public bool? EsAgente { get; set; }

        public bool? EsPersona { get; set; }

        public bool? EsBaja { get; set; }

        [StringLength(20)]
        public string Telefono1 { get; set; }

        [StringLength(20)]
        public string Telefono2 { get; set; }

        [StringLength(20)]
        public string Telefono3 { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(250)]
        public string eMail { get; set; }

        [StringLength(250)]
        public string PaginaWeb { get; set; }

        public int? IdDatoExtra { get; set; }

        public bool? GenerarPolizaAuto { get; set; }

        public int? PosibilidadPago { get; set; }

        public int? SistOrig { get; set; }

        [StringLength(40)]
        public string CodigoAdminPAQ { get; set; }

        public bool? EsResponsableGasto { get; set; }

        [StringLength(30)]
        public string CtaContableGasto { get; set; }

        public bool? PagarDoctosAMismoRFC { get; set; }

        public bool? GeneraContraCuentaDeudor { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdSubCategoria { get; set; }
    }
}
