using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Concepto de documento solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de conceptos de documento cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Conceptos de documento, como por
///     ejemplo los que implementan <see cref="IConceptoDocumentoRepository{T}" /> de <see cref="ConceptoDocumentoDto" />.
/// </summary>
public class ConceptoDocumentoDto
{
    /// <summary>
    ///     Id del concepto de documento.
    /// </summary>
    public int CIDCONCEPTODOCUMENTO { get; set; }

    /// <summary>
    ///     Código del concepto de documento.
    /// </summary>
    public string CCODIGOCONCEPTO { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del concepto de documento.
    /// </summary>
    public string CNOMBRECONCEPTO { get; set; } = string.Empty;
}
