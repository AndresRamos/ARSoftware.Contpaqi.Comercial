using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Almacén solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de almacenes cuando solo se necesitan algunas propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Almacenes, como por ejemplo los que
///     implementan <see cref="IAlmacenRepository{T}" /> de <see cref="AlmacenDto" />.
/// </summary>
public class AlmacenDto
{
    /// <summary>
    ///     Id del almacén.
    /// </summary>
    public int CIDALMACEN { get; set; }

    /// <summary>
    ///     Código del almacén.
    /// </summary>
    public string CCODIGOALMACEN { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del almacén.
    /// </summary>
    public string CNOMBREALMACEN { get; set; } = string.Empty;
}
