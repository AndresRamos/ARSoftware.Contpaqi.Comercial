// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Moneda
{
    /// <summary>
    ///     Id de la moneda del documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Nombre de la moneda.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;
}
