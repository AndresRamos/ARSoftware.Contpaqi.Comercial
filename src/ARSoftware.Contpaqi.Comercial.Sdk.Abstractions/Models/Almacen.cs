using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Almacen
{
    /// <summary>
    ///     Id del almacén.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Código del almacén.
    /// </summary>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del almacén.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra del almacén.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
