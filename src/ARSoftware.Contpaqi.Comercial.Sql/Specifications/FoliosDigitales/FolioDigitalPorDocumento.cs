using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.FoliosDigitales;

public sealed class FolioDigitalPorDocumento : Specification<admFoliosDigitales>
{
    public FolioDigitalPorDocumento(int conceptoId, int documentoId)
    {
        Query.Where(m => m.CIDCPTODOC == conceptoId && m.CIDDOCTO == documentoId);
    }
}
