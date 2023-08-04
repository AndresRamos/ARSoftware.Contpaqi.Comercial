using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Documento modelo solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de documentos modelo cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Documentos Modelo, como por ejemplo
///     los que implementan <see cref="IDocumentoModeloRepository{T}" /> de <see cref="DocumentoModeloDto" />.
/// </summary>
public class DocumentoModeloDto
{
    /// <summary>
    ///     Id del documento modelo.
    /// </summary>
    public int CIDDOCUMENTODE { get; set; }

    /// <summary>
    ///     Descripción del documento modelo.
    /// </summary>
    public string CDESCRIPCION { get; set; } = string.Empty;
}
