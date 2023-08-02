using System.Collections.Generic;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Agente
{
    /// <summary>
    ///     Id del agente.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Código del agente.
    /// </summary>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del agente.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Tipo del agente.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoAgente Tipo { get; set; } = TipoAgente.VentasCobro;

    /// <summary>
    ///     Datos extra del agente.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
