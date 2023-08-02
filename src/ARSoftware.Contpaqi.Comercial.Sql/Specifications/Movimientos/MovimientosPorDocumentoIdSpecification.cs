using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;

/// <summary>
///     Especificación para obtener los movimientos de un documento.
/// </summary>
public sealed class MovimientosPorDocumentoIdSpecification : Specification<admMovimientos>
{
    public MovimientosPorDocumentoIdSpecification(int idDocumento)
    {
        Query.Where(movimiento => movimiento.CIDDOCUMENTO == idDocumento);
    }
}
