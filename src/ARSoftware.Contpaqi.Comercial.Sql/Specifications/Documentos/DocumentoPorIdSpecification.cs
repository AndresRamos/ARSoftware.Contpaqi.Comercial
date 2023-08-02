using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Documentos;

/// <summary>
///     Especificación para obtener un documento por su id.
/// </summary>
public sealed class DocumentoPorIdSpecification : SingleResultSpecification<admDocumentos>
{
    public DocumentoPorIdSpecification(int idDocumento)
    {
        Query.Where(documento => documento.CIDDOCUMENTO == idDocumento);
    }
}
