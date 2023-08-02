using System.Collections.Generic;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Producto
{
    /// <summary>
    ///     Id del producto.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Codigo del producto.
    /// </summary>
    public string Codigo { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del producto.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Tipo del producto.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoProducto Tipo { get; set; } = TipoProducto.Producto;

    /// <summary>
    ///     Clave SAT del producto.
    /// </summary>
    public string ClaveSat { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra del producto.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
