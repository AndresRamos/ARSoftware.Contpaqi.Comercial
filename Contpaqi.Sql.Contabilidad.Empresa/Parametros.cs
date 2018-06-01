namespace Contpaqi.Sql.Contabilidad.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parametros
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdEmpresa { get; set; }

        [StringLength(254)]
        public string RepLegal { get; set; }

        [StringLength(20)]
        public string RFCRepresentante { get; set; }

        [StringLength(254)]
        public string RutaRespaldo { get; set; }

        [StringLength(254)]
        public string SalidaDisco { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(10)]
        public string CodPostal { get; set; }

        [StringLength(10)]
        public string ApdoPostal { get; set; }

        [StringLength(30)]
        public string Ciudad { get; set; }

        [StringLength(30)]
        public string Estado { get; set; }

        [StringLength(30)]
        public string Pais { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        [StringLength(20)]
        public string RegCamara { get; set; }

        [StringLength(20)]
        public string RegEstatal { get; set; }

        [StringLength(50)]
        public string EstructCta { get; set; }

        [StringLength(50)]
        public string Mascarilla { get; set; }

        [StringLength(30)]
        public string CtaFlujo { get; set; }

        [StringLength(10)]
        public string DelimExport { get; set; }

        public int? Ejercicios { get; set; }

        public int? EjerActual { get; set; }

        public int? PerActual { get; set; }

        public DateTime? FecIniHist { get; set; }

        [StringLength(100)]
        public string ParFunc { get; set; }

        [StringLength(10)]
        public string VersionBDD { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(50)]
        public string ModulosIntegrados { get; set; }

        [StringLength(36)]
        public string GuidDSL { get; set; }

        [StringLength(36)]
        public string GuidEmpresa { get; set; }

        [StringLength(36)]
        public string GuidDSLCreado { get; set; }

        [StringLength(200)]
        public string ApellPatRep { get; set; }

        [StringLength(200)]
        public string ApellMatRep { get; set; }

        [StringLength(254)]
        public string RazonSocial { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(250)]
        public string eMail { get; set; }

        [StringLength(15)]
        public string ParFuncCheques { get; set; }

        public DateTime? DiaTrabajo { get; set; }

        public int? DigitosCheque { get; set; }

        public double? MinimoLeyendaAbono { get; set; }

        [StringLength(50)]
        public string LeyendaAbono { get; set; }

        public double? PorcentajeIVA { get; set; }

        public double? PorcentajeISR { get; set; }

        [StringLength(254)]
        public string RutaAdminPAQ { get; set; }

        public int? ContadorCodigoPersona { get; set; }

        public int? EjercicioVigenteBN { get; set; }

        public int? PeriodoVigenteBN { get; set; }

        public DateTime? FechaInicioHistoriaBN { get; set; }

        [StringLength(50)]
        public string EstCliente { get; set; }

        [StringLength(50)]
        public string EstProveedor { get; set; }

        [StringLength(254)]
        public string Asunto { get; set; }

        [StringLength(1000)]
        public string Cuerpo { get; set; }

        [StringLength(254)]
        public string Firma { get; set; }

        [StringLength(100)]
        public string SMTPName { get; set; }

        [StringLength(36)]
        public string GuidCertificado { get; set; }

        [StringLength(36)]
        public string GuidCertificadoEntrega { get; set; }
    }
}
