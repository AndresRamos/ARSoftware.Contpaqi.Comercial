using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admDocumentos
{
    public int CIDDOCUMENTO { get; set; }

    public int CIDDOCUMENTODE { get; set; }

    public int CIDCONCEPTODOCUMENTO { get; set; }

    public string CSERIEDOCUMENTO { get; set; } = null!;

    public double CFOLIO { get; set; }

    public DateTime CFECHA { get; set; }

    public int CIDCLIENTEPROVEEDOR { get; set; }

    public string CRAZONSOCIAL { get; set; } = null!;

    public string CRFC { get; set; } = null!;

    public int CIDAGENTE { get; set; }

    public DateTime CFECHAVENCIMIENTO { get; set; }

    public DateTime CFECHAPRONTOPAGO { get; set; }

    public DateTime CFECHAENTREGARECEPCION { get; set; }

    public DateTime CFECHAULTIMOINTERES { get; set; }

    public int CIDMONEDA { get; set; }

    public double CTIPOCAMBIO { get; set; }

    public string CREFERENCIA { get; set; } = null!;

    public string? COBSERVACIONES { get; set; }

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

    public string CTEXTOEXTRA1 { get; set; } = null!;

    public string CTEXTOEXTRA2 { get; set; } = null!;

    public string CTEXTOEXTRA3 { get; set; } = null!;

    public DateTime CFECHAEXTRA { get; set; }

    public double CIMPORTEEXTRA1 { get; set; }

    public double CIMPORTEEXTRA2 { get; set; }

    public double CIMPORTEEXTRA3 { get; set; }

    public double CIMPORTEEXTRA4 { get; set; }

    public string CDESTINATARIO { get; set; } = null!;

    public string CNUMEROGUIA { get; set; } = null!;

    public string CMENSAJERIA { get; set; } = null!;

    public string CCUENTAMENSAJERIA { get; set; } = null!;

    public double CNUMEROCAJAS { get; set; }

    public double CPESO { get; set; }

    public int CBANOBSERVACIONES { get; set; }

    public int CBANDATOSENVIO { get; set; }

    public int CBANCONDICIONESCREDITO { get; set; }

    public int CBANGASTOS { get; set; }

    public double CUNIDADESPENDIENTES { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public double CIMPCHEQPAQ { get; set; }

    public int CSISTORIG { get; set; }

    public int CIDMONEDCA { get; set; }

    public double CTIPOCAMCA { get; set; }

    public int CESCFD { get; set; }

    public int CTIENECFD { get; set; }

    public string CLUGAREXPE { get; set; } = null!;

    public string CMETODOPAG { get; set; } = null!;

    public int CNUMPARCIA { get; set; }

    public int CCANTPARCI { get; set; }

    public string CCONDIPAGO { get; set; } = null!;

    public string CNUMCTAPAG { get; set; } = null!;

    public string CGUIDDOCUMENTO { get; set; } = null!;

    public string CUSUARIO { get; set; } = null!;

    public int CIDPROYECTO { get; set; }

    public int CIDCUENTA { get; set; }

    public string CTRANSACTIONID { get; set; } = null!;

    public int CIDCOPIADE { get; set; }

    public string CVERESQUE { get; set; } = null!;
}
