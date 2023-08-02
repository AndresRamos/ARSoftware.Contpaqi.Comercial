using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Parametros
{
    /// <summary>
    ///     RFC de la empresa.
    /// </summary>
    public string Rfc { get; set; } = string.Empty;

    /// <summary>
    ///     Identificador global único de la empresa en el Administrador de Documentos Digitales (ADD).
    /// </summary>
    public string GuidAdd { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra de los parametros de la empresa.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
