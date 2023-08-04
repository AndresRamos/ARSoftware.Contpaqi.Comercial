using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;

/// <summary>
///     Especificación para obtener los conceptos de un documento modelo.
/// </summary>
public sealed class ConceptosPorDocumentoModeloIdSpecification : Specification<admConceptos>
{
    public ConceptosPorDocumentoModeloIdSpecification(int documentoModeloId)
    {
        Query.Where(concepto => concepto.CIDDOCUMENTODE == documentoModeloId);
    }
}
