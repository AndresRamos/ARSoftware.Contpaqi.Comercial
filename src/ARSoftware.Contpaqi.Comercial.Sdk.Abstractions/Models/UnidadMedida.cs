using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class UnidadMedida
{
    /// <summary>
    ///     Id de la unidad.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Abreviatura de la unidad.
    /// </summary>
    public string Abreviatura { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre de la unidad.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Clave SAT de acuerdo al Anexo 20 3.3
    /// </summary>
    public string ClaveSat { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra de la unidad.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
