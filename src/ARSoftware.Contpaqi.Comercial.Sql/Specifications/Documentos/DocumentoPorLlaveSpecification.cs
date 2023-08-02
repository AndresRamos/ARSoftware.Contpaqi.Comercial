using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Documentos;

/// <summary>
///     Especificación para obtener un documento por su llave.
/// </summary>
public sealed class DocumentoPorLlaveSpecification : SingleResultSpecification<admDocumentos>
{
    public DocumentoPorLlaveSpecification(int idConcepto, string serie, double folio)
    {
        // ReSharper disable once CompareOfFloatsByEqualityOperator

        Query.Where(documento =>
            documento.CIDCONCEPTODOCUMENTO == idConcepto && documento.CSERIEDOCUMENTO == serie && documento.CFOLIO == folio);
    }
}
