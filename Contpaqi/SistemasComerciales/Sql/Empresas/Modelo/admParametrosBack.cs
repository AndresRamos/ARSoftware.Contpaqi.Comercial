namespace Contpaqi.SistemasComerciales.Sql.Empresas.Modelo
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("admParametrosBack")]
    public partial class admParametrosBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIDEMPRESA { get; set; }

        [Required]
        [StringLength(60)]
        public string CNOMBREEMPRESA { get; set; }

        public int CEXISTENCIANEGATIVA { get; set; }

        public int CIDEJERCICIOACTUAL { get; set; }

        public int CPERIODOACTUAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CRFCEMPRESA { get; set; }

        [Required]
        [StringLength(20)]
        public string CCURPEMPRESA { get; set; }

        [Required]
        [StringLength(50)]
        public string CREGISTROCAMARA { get; set; }

        [Required]
        [StringLength(50)]
        public string CCUENTAESTATAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CREPRESENTANTELEGAL { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRECORTO { get; set; }

        public int CIDALMACENASUMIDO { get; set; }

        public DateTime CFECHACIERRE { get; set; }

        public int CDECIMALESUNIDADES { get; set; }

        public int CDECIMALESPRECIOVENTA { get; set; }

        public int CDECIMALESCOSTOS { get; set; }

        public int CDECIMALESTIPOSCAMBIO { get; set; }

        public int CBANMARGENUTILIDAD { get; set; }

        public double CIMPUESTO1 { get; set; }

        public double CIMPUESTO2 { get; set; }

        public double CIMPUESTO3 { get; set; }

        public int CUSOCUOTAIESPS { get; set; }

        public double CRETENCIONCLIENTE1 { get; set; }

        public double CRETENCIONCLIENTE2 { get; set; }

        public double CRETENCIONPROVEEDOR1 { get; set; }

        public double CRETENCIONPROVEEDOR2 { get; set; }

        public double CDESCUENTODOCTO { get; set; }

        public double CDESCUENTOMOVTO { get; set; }

        public double CCOMISIONVENTA { get; set; }

        public double CCOMISIONCOBRO { get; set; }

        public int CLISTAPRECIOGENERAL { get; set; }

        public int CIDALMACENCONSIGNACION { get; set; }

        public int CMANEJOFECHA { get; set; }

        public int CIDMONEDABASE { get; set; }

        public int CIDCLIENTEMOSTRADOR { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTACONTPAQ { get; set; }

        public int CUSACARACTERISTICAS { get; set; }

        public int CUSAUNIDADNC { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLACLIENTES { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLAPRODUCTO { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLAALMACEN { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLAAGENTE { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLARFC { get; set; }

        [Required]
        [StringLength(30)]
        public string CMASCARILLACURP { get; set; }

        public int CBANDIRECCION { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA1 { get; set; }

        public int CIDMONEDALISTA1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA2 { get; set; }

        public int CIDMONEDALISTA2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA3 { get; set; }

        public int CIDMONEDALISTA3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA4 { get; set; }

        public int CIDMONEDALISTA4 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA5 { get; set; }

        public int CIDMONEDALISTA5 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA6 { get; set; }

        public int CIDMONEDALISTA6 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA7 { get; set; }

        public int CIDMONEDALISTA7 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA8 { get; set; }

        public int CIDMONEDALISTA8 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA9 { get; set; }

        public int CIDMONEDALISTA9 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRELISTA10 { get; set; }

        public int CIDMONEDALISTA10 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREIMPUESTO1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREIMPUESTO2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREIMPUESTO3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRERETENCION1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBRERETENCION2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREGASTO1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREGASTO2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREGASTO3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTOMOV1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTOMOV2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTOMOV3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTOMOV4 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTOMOV5 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTODOC1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CNOMBREDESCUENTODOC2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL1 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL2 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL3 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL4 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL5 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL6 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL7 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL8 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL9 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL10 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCONTGENERAL11 { get; set; }

        public double CCONSECUTIVODIARIO { get; set; }

        public double CCONSECUTIVOINGRESOS { get; set; }

        public double CCONSECUTIVOEGRESOS { get; set; }

        public double CCONSECUTIVOORDEN { get; set; }

        [Required]
        [StringLength(23)]
        public string CTIMESTAMP { get; set; }

        public DateTime CFECHACONGELAMIENTO { get; set; }

        public int CBANCONGELAMIENTO { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAEMPRESAPRED { get; set; }

        public int CBANVISTASVENTAS { get; set; }

        public int CBANVISTASCOMPRAS { get; set; }

        public int CBANVISTASCTEPROVINVEN { get; set; }

        public int CBANVISTASCATALOGOS { get; set; }

        public int CAFECTARINVAUTOMATICO { get; set; }

        public int CMETODOCOSTEO { get; set; }

        public int CBANOBLIGATORIOEXISTENCIA { get; set; }

        public int CNUMIMPUESTOIVA { get; set; }

        [Required]
        [StringLength(20)]
        public string CVERSIONACTUAL { get; set; }

        public int CPRECIOSCONIVA { get; set; }

        public int CIDPRODU01 { get; set; }

        public int CIDPRODU02 { get; set; }

        public int CIDPRODU03 { get; set; }

        public int CIDPRODU04 { get; set; }

        public int CIDPRODU05 { get; set; }

        public int CIDCONCE01 { get; set; }

        public int CIDCONCE02 { get; set; }

        public int CIDCLIEN02 { get; set; }

        public int CIDCONCE03 { get; set; }

        public int CIDCONCE04 { get; set; }

        public int CPERANTFUT { get; set; }

        public int CVMOSTPEND { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVTEXEX1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVTEXEX2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVTEXEX3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVIMPEX1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVIMPEX2 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVIMPEX3 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVIMPEX4 { get; set; }

        [Required]
        [StringLength(20)]
        public string CMOVFECEX1 { get; set; }

        public int CVISTAAJ01 { get; set; }

        public int CESCFD { get; set; }

        public int CTIEMPOCFD { get; set; }

        public int CINTENTOS { get; set; }

        public int CINTERFAZ { get; set; }

        public int CCONTSIMUL { get; set; }

        public int CBANACTPLP { get; set; }

        public int CPOSFOLIO { get; set; }

        public int CPOSMODOIM { get; set; }

        public int CCALCOSTO1 { get; set; }

        public int CGENBITACS { get; set; }

        public int CSUGERIRRE { get; set; }

        public int CIDKEYEMP { get; set; }

        public int CALMACENAC { get; set; }

        [Required]
        [StringLength(20)]
        public string CVERPOSI { get; set; }

        public int CIDSUCURSA { get; set; }

        public int CPERFIL { get; set; }

        public int CMOSTRAR01 { get; set; }

        public int CBITACORA0 { get; set; }

        public int CBITACORA1 { get; set; }

        public int CBITACORA2 { get; set; }

        public int CBITACORA3 { get; set; }

        public int CBITACORA4 { get; set; }

        public int CBITACORA5 { get; set; }

        public int CBITACORA6 { get; set; }

        public int CBITACORA7 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCIVA15 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCIVA10 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCIVAOT { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCIVA16 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGCIVA11 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGPIVA15 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGPIVA10 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGPIVAOT { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGPIVA16 { get; set; }

        [Required]
        [StringLength(50)]
        public string CSEGPIVA11 { get; set; }

        public int CGENAJ2010 { get; set; }

        public DateTime CFECAJ2010 { get; set; }

        public int CAJ2010ORI { get; set; }

        [Required]
        [StringLength(60)]
        public string CHOST { get; set; }

        public int CTIPESTCAL { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAPLA01 { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAPLA02 { get; set; }

        public DateTime CFECDONAT { get; set; }

        [Required]
        [StringLength(30)]
        public string CNUMDONAT { get; set; }

        [Required]
        [StringLength(253)]
        public string CHOSTPROXY { get; set; }

        public int CPTOPROXY { get; set; }

        [Required]
        [StringLength(60)]
        public string CUSRPROXY { get; set; }

        [Required]
        [StringLength(60)]
        public string CHOSTSMTP { get; set; }

        public int CPTOPOP { get; set; }

        public int CPTOSMTP { get; set; }

        public int CCNXSEGPOP { get; set; }

        [Required]
        [StringLength(253)]
        public string CRUTAENTREGA { get; set; }

        public int CPREFIJORFC { get; set; }

        [Required]
        [StringLength(20)]
        public string CVALIDACFD { get; set; }

        [Required]
        [StringLength(253)]
        public string CREGIMFISC { get; set; }

        [Required]
        [StringLength(30)]
        public string CAUTRVOE { get; set; }

        [Required]
        [StringLength(253)]
        public string CLEYENDON1 { get; set; }

        [Required]
        [StringLength(253)]
        public string CLEYENDON2 { get; set; }

        [Required]
        [StringLength(253)]
        public string CASUNTO { get; set; }

        [Column(TypeName = "text")]
        public string CCUERPO { get; set; }

        [Required]
        [StringLength(253)]
        public string CFIRMA { get; set; }

        [Required]
        [StringLength(253)]
        public string CADJUNTO1 { get; set; }

        [Required]
        [StringLength(253)]
        public string CADJUNTO2 { get; set; }

        [Required]
        [StringLength(253)]
        public string CCORREOPRU { get; set; }

        [Required]
        [StringLength(40)]
        public string CGUIDDSL { get; set; }

        [Required]
        [StringLength(40)]
        public string CGUIDEMPRESA { get; set; }
    }
}
