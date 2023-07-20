using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class ConceptoPorCodigoSpecification : SingleResultSpecification<admConceptos>
{
    public ConceptoPorCodigoSpecification(string codigoConcepto)
    {
        Query.Where(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto);
    }
}

public sealed class ConceptoPorIdSpecification : SingleResultSpecification<admConceptos>
{
    public ConceptoPorIdSpecification(int idConcepto)
    {
        Query.Where(concepto => concepto.CIDCONCEPTODOCUMENTO == idConcepto);
    }
}

public sealed class ConceptosPorDocumentoModeloIdSpecification : Specification<admConceptos>
{
    public ConceptosPorDocumentoModeloIdSpecification(int documentoModeloId)
    {
        Query.Where(concepto => concepto.CIDDOCUMENTODE == documentoModeloId);
    }
}