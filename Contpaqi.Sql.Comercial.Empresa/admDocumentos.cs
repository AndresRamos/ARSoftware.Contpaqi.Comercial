namespace Contpaqi.Sql.Comercial.Empresa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admDocumentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDDOCUMENTO { get; set; }

        public int CIDDOCUMENTODE { get; set; }

        public int CIDCONCEPTODOCUMENTO { get; set; }

        [Required]
        [StringLength(11)]
        public string CSERIEDOCUMENTO { get; set; }

        public double CFOLIO { get; set; }

        public DateTime CFECHA { get; set; }

        public int CIDCLIENTEPROVEEDOR { get; set; }

        [Required]
        [StringLength(60)]
        public string CRAZONSOCIAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFC { get; set; }

        public int CIDAGENTE { get; set; }

        public DateTime CFECHAVENCIMIENTO { get; set; }

        public DateTime CFECHAPRONTOPAGO { get; set; }

        public DateTime CFECHAENTREGARECEPCION { get; set; }

        public DateTime CFECHAULTIMOINTERES { get; set; }

        public int CIDMONEDA { get; set; }

        public double CTIPOCAMBIO { get; set; }

        [Required]
        [StringLength(20)]
        public string CREFERENCIA { get; set; }

        [Column(TypeName = "text")]
        public string COBSERVACIONES { get; set; }

        public int CNATURALEZA { get; set; }

        public int CIDDOCUMENTOORIGEN { get; set; }

        public int CPLANTILLA { get; set; }

        public int CUSACLIENTE { get; set; }

        public int CUSAPROVEEDOR { get; set; }

        public int CAFECTADO { get; set; }

        public int CIMPRESO { get; set; }

        public int CCANCELADO { get; set; }

        public int CDEVUELTO { get; set; }

        public int CIDPREPOLIZA { get; set; }

        public int CIDPREPOLIZACANCELACION { get; set; }

        public int CESTADOCONTABLE { get; set; }

        public double CNETO { get; set; }

        public double CIMPUESTO1 { get; set; }

        public double CIMPUESTO2 { get; set; }

        public double CIMPUESTO3 { get; set; }

        public double CRETENCION1 { get; set; }

        public double CRETENCION2 { get; set; }

        public double CDESCUENTOMOV { get; set; }

        public double CDESCUENTODOC1 { get; set; }

        public double CDESCUENTODOC2 { get; set; }

        public double CGASTO1 { get; set; }

        public double CGASTO2 { get; set; }

        public double CGASTO3 { get; set; }

        public double CTOTAL { get; set; }

        public double CPENDIENTE { get; set; }

        public double CTOTALUNIDADES { get; set; }

        public double CDESCUENTOPRONTOPAGO { get; set; }

        public double CPORCENTAJEIMPUESTO1 { get; set; }

        public double CPORCENTAJEIMPUESTO2 { get; set; }

        public double CPORCENTAJEIMPUESTO3 { get; set; }

        public double CPORCENTAJERETENCION1 { get; set; }

        public double CPORCENTAJERETENCION2 { get; set; }

        public double CPORCENTAJEINTERES { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CTEXTOEXTRA3 { get; set; }

        public DateTime CFECHAEXTRA { get; set; }

        public double CIMPORTEEXTRA1 { get; set; }

        public double CIMPORTEEXTRA2 { get; set; }

        public double CIMPORTEEXTRA3 { get; set; }

        public double CIMPORTEEXTRA4 { get; set; }

        [Required]
        [StringLength(60)]
        public string CDESTINATARIO { get; set; }

        [Required]
        [StringLength(60)]
        public string CNUMEROGUIA { get; set; }

        [Required]
        [StringLength(20)]
        public string CMENSAJERIA { get; set; }

        [Required]
        [StringLength(120)]
        public string CCUENTAMENSAJERIA { get; set; }

        public double CNUMEROCAJAS { get; set; }

        public double CPESO { get; set; }

        public int CBANOBSERVACIONES { get; set; }

        public int CBANDATOSENVIO { get; set; }

        public int CBANCONDICIONESCREDITO { get; set; }

        public int CBANGASTOS { get; set; }

        public double CUNIDADESPENDIENTES { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public double CIMPCHEQPAQ { get; set; }

        public int CSISTORIG { get; set; }

        public int CIDMONEDCA { get; set; }

        public double CTIPOCAMCA { get; set; }

        public int CESCFD { get; set; }

        public int CTIENECFD { get; set; }

        [Required]
        [StringLength(380)]
        public string CLUGAREXPE { get; set; }

        [Required]
        [StringLength(100)]
        public string CMETODOPAG { get; set; }

        public int CNUMPARCIA { get; set; }

        public int CCANTPARCI { get; set; }

        [Required]
        [StringLength(253)]
        public string CCONDIPAGO { get; set; }

        [Required]
        [StringLength(100)]
        public string CNUMCTAPAG { get; set; }

        [Required]
        [StringLength(40)]
        public string CGUIDDOCUMENTO { get; set; }

        [Required]
        [StringLength(15)]
        public string CUSUARIO { get; set; }

        public int CIDPROYECTO { get; set; }

        public int CIDCUENTA { get; set; }

        [Required]
        [StringLength(26)]
        public string CTRANSACTIONID { get; set; }

        public int CIDCOPIADE { get; set; }
    }
}
