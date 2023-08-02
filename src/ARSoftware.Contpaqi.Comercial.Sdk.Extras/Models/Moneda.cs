// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedMember.Global

using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class Moneda
{
    public static readonly Moneda PesoMexicano = new() { Id = MonedaEnum.PesoMexicano.Value, Nombre = MonedaEnum.PesoMexicano.Name };
    public static readonly Moneda DolarAmericano = new() { Id = MonedaEnum.DolarAmericano.Value, Nombre = MonedaEnum.DolarAmericano.Name };

    /// <summary>
    ///     Id de la moneda del documento.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Nombre de la moneda.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;
}
