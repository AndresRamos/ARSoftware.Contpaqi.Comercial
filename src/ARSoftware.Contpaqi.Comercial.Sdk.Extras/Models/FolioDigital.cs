using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class FolioDigital
{
    public string Uuid { get; set; } = string.Empty;
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}