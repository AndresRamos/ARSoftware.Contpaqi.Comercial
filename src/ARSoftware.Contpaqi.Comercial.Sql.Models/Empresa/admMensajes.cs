using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMensajes
{
    public string CMESSAGEID { get; set; } = null!;

    public string CINBOXID { get; set; } = null!;

    public string CALIAS { get; set; } = null!;

    public string? CBODY { get; set; }

    public string CCONTENTTYPE { get; set; } = null!;

    public string CCONTENTENCODING { get; set; } = null!;

    public DateTime CDUEDATE { get; set; }

    public string CPRIORITY { get; set; } = null!;

    public string? CTAGS { get; set; }

    public DateTime CQUEUEDAT { get; set; }

    public int CSTATUS { get; set; }

    public string CUSUARIO { get; set; } = null!;

    public string CPROCESO { get; set; } = null!;

    public string CDATOS { get; set; } = null!;

    public DateTime CFECHA { get; set; }

    public string CHORA { get; set; } = null!;

    public string CERROR { get; set; } = null!;
}
