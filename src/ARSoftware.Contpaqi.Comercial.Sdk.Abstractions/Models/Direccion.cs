using System.Collections.Generic;
using System.Text.Json.Serialization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Direccion
{
    /// <summary>
    ///     Id de la dirección.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Tipo de catálogo de la dirección.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoCatalogoDireccion TipoCatalogo { get; set; }

    /// <summary>
    ///     Tipo de dirección.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoDireccion Tipo { get; set; }

    /// <summary>
    ///     Nombre de la calle.
    /// </summary>
    public string Calle { get; set; } = string.Empty;

    /// <summary>
    ///     Número exterior de la calle.
    /// </summary>
    public string NumeroExterior { get; set; } = string.Empty;

    /// <summary>
    ///     Número interior del edificio o local.
    /// </summary>
    public string NumeroInterior { get; set; } = string.Empty;

    /// <summary>
    ///     Colonia o fraccionamiento.
    /// </summary>
    public string Colonia { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre de la ciudad.
    /// </summary>
    public string Ciudad { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del estado.
    /// </summary>
    public string Estado { get; set; } = string.Empty;

    /// <summary>
    ///     Código postal.
    /// </summary>
    public string CodigoPostal { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del país.
    /// </summary>
    public string Pais { get; set; } = string.Empty;

    /// <summary>
    ///     Datos extra de la dirección.
    /// </summary>
    public Dictionary<string, string> DatosExtra { get; set; } = new();
}
