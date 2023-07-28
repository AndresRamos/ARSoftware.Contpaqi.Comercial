using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class Parametros
{
    public string Rfc { get; set; } = string.Empty;
    public string GuidAdd { get; set; } = string.Empty;
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}