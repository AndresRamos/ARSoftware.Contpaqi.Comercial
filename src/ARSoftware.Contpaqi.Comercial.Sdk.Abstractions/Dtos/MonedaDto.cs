using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Moneda solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de monedas cuando solo se necesitan algunas propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Monedas, como por ejemplo los que
///     implementan <see cref="IMonedaRepository{T}" /> de <see cref="MonedaDto" />.
/// </summary>
public class MonedaDto
{
    /// <summary>
    ///     Id de la moneda del documento.
    /// </summary>
    public int CIDMONEDA { get; set; }

    /// <summary>
    ///     Nombre de la moneda.
    /// </summary>
    public string CNOMBREMONEDA { get; set; } = string.Empty;
}
