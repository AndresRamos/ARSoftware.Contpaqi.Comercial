using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class FolioDigital
{
    /// <summary>
    ///     Id del folio digital.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     El UUID del documento timbrado.
    /// </summary>
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra del folio digital.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
