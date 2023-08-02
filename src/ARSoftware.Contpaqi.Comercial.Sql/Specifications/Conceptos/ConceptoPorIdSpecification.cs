using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;

/// <summary>
///     Especificación para obtener un concepto por su id.
/// </summary>
public sealed class ConceptoPorIdSpecification : SingleResultSpecification<admConceptos>
{
    public ConceptoPorIdSpecification(int idConcepto)
    {
        Query.Where(concepto => concepto.CIDCONCEPTODOCUMENTO == idConcepto);
    }
}
