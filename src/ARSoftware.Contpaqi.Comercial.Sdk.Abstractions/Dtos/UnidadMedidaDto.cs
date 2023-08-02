using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Unidad de medida solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de unidades de medida cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Unidades de Medida, como por ejemplo
///     los que implementan <see cref="IUnidadMedidaRepository{T}" /> de <see cref="UnidadMedidaDto" />.
/// </summary>
public class UnidadMedidaDto
{
    /// <summary>
    ///     Id de la unidad.
    /// </summary>
    public int CIDUNIDAD { get; set; }

    /// <summary>
    ///     Abreviatura de la unidad.
    /// </summary>
    public string CABREVIATURA { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre de la unidad.
    /// </summary>
    public string CNOMBREUNIDAD { get; set; } = string.Empty;

    /// <summary>
    ///     Clave SAT de acuerdo al Anexo 20 3.3
    /// </summary>
    public string CCLAVEINT { get; set; } = string.Empty;
}
