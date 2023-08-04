using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admParametrosBack
{
    public int CIDEMPRESA { get; set; }

    public string CNOMBREEMPRESA { get; set; } = null!;

    public int CEXISTENCIANEGATIVA { get; set; }

    public int CIDEJERCICIOACTUAL { get; set; }

    public int CPERIODOACTUAL { get; set; }

    public string CRFCEMPRESA { get; set; } = null!;

    public string CCURPEMPRESA { get; set; } = null!;

    public string CREGISTROCAMARA { get; set; } = null!;

    public string CCUENTAESTATAL { get; set; } = null!;

    public string CREPRESENTANTELEGAL { get; set; } = null!;

    public string CNOMBRECORTO { get; set; } = null!;

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

    public string CRUTACONTPAQ { get; set; } = null!;

    public int CUSACARACTERISTICAS { get; set; }

    public int CUSAUNIDADNC { get; set; }

    public string CMASCARILLACLIENTES { get; set; } = null!;

    public string CMASCARILLAPRODUCTO { get; set; } = null!;

    public string CMASCARILLAALMACEN { get; set; } = null!;

    public string CMASCARILLAAGENTE { get; set; } = null!;

    public string CMASCARILLARFC { get; set; } = null!;

    public string CMASCARILLACURP { get; set; } = null!;

    public int CBANDIRECCION { get; set; }

    public string CNOMBRELISTA1 { get; set; } = null!;

    public int CIDMONEDALISTA1 { get; set; }

    public string CNOMBRELISTA2 { get; set; } = null!;

    public int CIDMONEDALISTA2 { get; set; }

    public string CNOMBRELISTA3 { get; set; } = null!;

    public int CIDMONEDALISTA3 { get; set; }

    public string CNOMBRELISTA4 { get; set; } = null!;

    public int CIDMONEDALISTA4 { get; set; }

    public string CNOMBRELISTA5 { get; set; } = null!;

    public int CIDMONEDALISTA5 { get; set; }

    public string CNOMBRELISTA6 { get; set; } = null!;

    public int CIDMONEDALISTA6 { get; set; }

    public string CNOMBRELISTA7 { get; set; } = null!;

    public int CIDMONEDALISTA7 { get; set; }

    public string CNOMBRELISTA8 { get; set; } = null!;

    public int CIDMONEDALISTA8 { get; set; }

    public string CNOMBRELISTA9 { get; set; } = null!;

    public int CIDMONEDALISTA9 { get; set; }

    public string CNOMBRELISTA10 { get; set; } = null!;

    public int CIDMONEDALISTA10 { get; set; }

    public string CNOMBREIMPUESTO1 { get; set; } = null!;

    public string CNOMBREIMPUESTO2 { get; set; } = null!;

    public string CNOMBREIMPUESTO3 { get; set; } = null!;

    public string CNOMBRERETENCION1 { get; set; } = null!;

    public string CNOMBRERETENCION2 { get; set; } = null!;

    public string CNOMBREGASTO1 { get; set; } = null!;

    public string CNOMBREGASTO2 { get; set; } = null!;

    public string CNOMBREGASTO3 { get; set; } = null!;

    public string CNOMBREDESCUENTOMOV1 { get; set; } = null!;

    public string CNOMBREDESCUENTOMOV2 { get; set; } = null!;

    public string CNOMBREDESCUENTOMOV3 { get; set; } = null!;

    public string CNOMBREDESCUENTOMOV4 { get; set; } = null!;

    public string CNOMBREDESCUENTOMOV5 { get; set; } = null!;

    public string CNOMBREDESCUENTODOC1 { get; set; } = null!;

    public string CNOMBREDESCUENTODOC2 { get; set; } = null!;

    public string CSEGCONTGENERAL1 { get; set; } = null!;

    public string CSEGCONTGENERAL2 { get; set; } = null!;

    public string CSEGCONTGENERAL3 { get; set; } = null!;

    public string CSEGCONTGENERAL4 { get; set; } = null!;

    public string CSEGCONTGENERAL5 { get; set; } = null!;

    public string CSEGCONTGENERAL6 { get; set; } = null!;

    public string CSEGCONTGENERAL7 { get; set; } = null!;

    public string CSEGCONTGENERAL8 { get; set; } = null!;

    public string CSEGCONTGENERAL9 { get; set; } = null!;

    public string CSEGCONTGENERAL10 { get; set; } = null!;

    public string CSEGCONTGENERAL11 { get; set; } = null!;

    public double CCONSECUTIVODIARIO { get; set; }

    public double CCONSECUTIVOINGRESOS { get; set; }

    public double CCONSECUTIVOEGRESOS { get; set; }

    public double CCONSECUTIVOORDEN { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public DateTime CFECHACONGELAMIENTO { get; set; }

    public int CBANCONGELAMIENTO { get; set; }

    public string CRUTAEMPRESAPRED { get; set; } = null!;

    public int CBANVISTASVENTAS { get; set; }

    public int CBANVISTASCOMPRAS { get; set; }

    public int CBANVISTASCTEPROVINVEN { get; set; }

    public int CBANVISTASCATALOGOS { get; set; }

    public int CAFECTARINVAUTOMATICO { get; set; }

    public int CMETODOCOSTEO { get; set; }

    public int CBANOBLIGATORIOEXISTENCIA { get; set; }

    public int CNUMIMPUESTOIVA { get; set; }

    public string CVERSIONACTUAL { get; set; } = null!;

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

    public string CMOVTEXEX1 { get; set; } = null!;

    public string CMOVTEXEX2 { get; set; } = null!;

    public string CMOVTEXEX3 { get; set; } = null!;

    public string CMOVIMPEX1 { get; set; } = null!;

    public string CMOVIMPEX2 { get; set; } = null!;

    public string CMOVIMPEX3 { get; set; } = null!;

    public string CMOVIMPEX4 { get; set; } = null!;

    public string CMOVFECEX1 { get; set; } = null!;

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

    public string CVERPOSI { get; set; } = null!;

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

    public string CSEGCIVA15 { get; set; } = null!;

    public string CSEGCIVA10 { get; set; } = null!;

    public string CSEGCIVAOT { get; set; } = null!;

    public string CSEGCIVA16 { get; set; } = null!;

    public string CSEGCIVA11 { get; set; } = null!;

    public string CSEGPIVA15 { get; set; } = null!;

    public string CSEGPIVA10 { get; set; } = null!;

    public string CSEGPIVAOT { get; set; } = null!;

    public string CSEGPIVA16 { get; set; } = null!;

    public string CSEGPIVA11 { get; set; } = null!;

    public int CGENAJ2010 { get; set; }

    public DateTime CFECAJ2010 { get; set; }

    public int CAJ2010ORI { get; set; }

    public string CHOST { get; set; } = null!;

    public int CTIPESTCAL { get; set; }

    public string CRUTAPLA01 { get; set; } = null!;

    public string CRUTAPLA02 { get; set; } = null!;

    public DateTime CFECDONAT { get; set; }

    public string CNUMDONAT { get; set; } = null!;

    public string CHOSTPROXY { get; set; } = null!;

    public int CPTOPROXY { get; set; }

    public string CUSRPROXY { get; set; } = null!;

    public string CHOSTSMTP { get; set; } = null!;

    public int CPTOPOP { get; set; }

    public int CPTOSMTP { get; set; }

    public int CCNXSEGPOP { get; set; }

    public string CRUTAENTREGA { get; set; } = null!;

    public int CPREFIJORFC { get; set; }

    public string CVALIDACFD { get; set; } = null!;

    public string CREGIMFISC { get; set; } = null!;

    public string CAUTRVOE { get; set; } = null!;

    public string CLEYENDON1 { get; set; } = null!;

    public string CLEYENDON2 { get; set; } = null!;

    public string CASUNTO { get; set; } = null!;

    public string? CCUERPO { get; set; }

    public string CFIRMA { get; set; } = null!;

    public string CADJUNTO1 { get; set; } = null!;

    public string CADJUNTO2 { get; set; } = null!;

    public string CCORREOPRU { get; set; } = null!;

    public string CGUIDDSL { get; set; } = null!;

    public string CGUIDEMPRESA { get; set; } = null!;

    public string? CTOKENCN { get; set; }

    public string? CREFRESHTOKENCN { get; set; }

    public string? CURLWSTORE { get; set; }
}
