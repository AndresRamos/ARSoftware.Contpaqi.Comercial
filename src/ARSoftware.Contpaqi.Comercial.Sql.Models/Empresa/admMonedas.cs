using System;
using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

public partial class admMonedas
{
    public int CIDMONEDA { get; set; }

    public string CNOMBREMONEDA { get; set; } = null!;

    public string CSIMBOLOMONEDA { get; set; } = null!;

    public int CPOSICIONSIMBOLO { get; set; }

    public string CPLURAL { get; set; } = null!;

    public string CSINGULAR { get; set; } = null!;

    public string CDESCRIPCIONPROTEGIDA { get; set; } = null!;

    public int CIDBANDERA { get; set; }

    public int CDECIMALESMONEDA { get; set; }

    public string CTIMESTAMP { get; set; } = null!;

    public string CCLAVESAT { get; set; } = null!;
}
