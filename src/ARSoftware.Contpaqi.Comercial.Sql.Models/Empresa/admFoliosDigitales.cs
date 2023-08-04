using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admFoliosDigitales
{
    public int CIDFOLDIG { get; set; }

    public int CIDDOCTODE { get; set; }

    public int CIDCPTODOC { get; set; }

    public int CIDDOCTO { get; set; }

    public int CIDDOCALDI { get; set; }

    public int CIDFIRMARL { get; set; }

    public int CNOORDEN { get; set; }

    public string CSERIE { get; set; } = null!;

    public double CFOLIO { get; set; }

    public int CNOAPROB { get; set; }

    public DateTime CFECAPROB { get; set; }

    public int CESTADO { get; set; }

    public int CENTREGADO { get; set; }

    public DateTime CFECHAEMI { get; set; }

    public string CHORAEMI { get; set; } = null!;

    public string CEMAIL { get; set; } = null!;

    public string CARCHDIDIS { get; set; } = null!;

    public int CIDCPTOORI { get; set; }

    public DateTime CFECHACANC { get; set; }

    public string CHORACANC { get; set; } = null!;

    public int CESTRAD { get; set; }

    public string? CCADPEDI { get; set; }

    public string CARCHCBB { get; set; } = null!;

    public DateTime CINIVIG { get; set; }

    public DateTime CFINVIG { get; set; }

    public string CTIPO { get; set; } = null!;

    public string CSERIEREC { get; set; } = null!;

    public double? CFOLIOREC { get; set; }

    public string CRFC { get; set; } = null!;

    public string CRAZON { get; set; } = null!;

    public int CSISORIGEN { get; set; }

    public int CEJERPOL { get; set; }

    public int CPERPOL { get; set; }

    public int CTIPOPOL { get; set; }

    public int CNUMPOL { get; set; }

    public string CTIPOLDESC { get; set; } = null!;

    public double CTOTAL { get; set; }

    public string CALIASBDCT { get; set; } = null!;

    public int CCFDPRUEBA { get; set; }

    public string CDESESTADO { get; set; } = null!;

    public int CPAGADOBAN { get; set; }

    public string CDESPAGBAN { get; set; } = null!;

    public string CREFEREN01 { get; set; } = null!;

    public string COBSERVA01 { get; set; } = null!;

    public string CCODCONCBA { get; set; } = null!;

    public string CDESCONCBA { get; set; } = null!;

    public string CNUMCTABAN { get; set; } = null!;

    public string CFOLIOBAN { get; set; } = null!;

    public int CIDDOCDEBA { get; set; }

    public string CUSUAUTBAN { get; set; } = null!;

    public string CUUID { get; set; } = null!;

    public string CUSUBAN01 { get; set; } = null!;

    public int CAUTUSBA01 { get; set; }

    public string CUSUBAN02 { get; set; } = null!;

    public int CAUTUSBA02 { get; set; }

    public string CUSUBAN03 { get; set; } = null!;

    public int CAUTUSBA03 { get; set; }

    public string CDESCAUT01 { get; set; } = null!;

    public string CDESCAUT02 { get; set; } = null!;

    public string CDESCAUT03 { get; set; } = null!;

    public int CERRORVAL { get; set; }

    public string CACUSECAN { get; set; } = null!;

    public string CIDDOCTODSL { get; set; } = null!;
}
