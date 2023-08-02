using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Conceptos;

/// <summary>
///     Especificación para obtener un concepto por su código.
/// </summary>
public sealed class ConceptoPorCodigoSpecification : SingleResultSpecification<admConceptos>
{
    public ConceptoPorCodigoSpecification(string codigoConcepto)
    {
        Query.Where(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto);
    }
}
