using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class ConceptoDocumento
{
    /// <summary>
    ///     Id del concepto de documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Código del concepto de documento.
    /// </summary>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del concepto de documento.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra del concepto de documento.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
