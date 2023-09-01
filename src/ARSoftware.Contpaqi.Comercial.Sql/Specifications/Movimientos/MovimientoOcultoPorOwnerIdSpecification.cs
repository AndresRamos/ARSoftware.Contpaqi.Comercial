using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;

/// <summary>
///     Especificación para obtener los movimientos ocultos de un movimiento owner.
/// </summary>
public sealed class MovimientoOcultoPorOwnerIdSpecification : Specification<admMovimientos>
{
    public MovimientoOcultoPorOwnerIdSpecification(int idMovimientoOwner)
    {
        Query.Where(m => m.CMOVTOOCULTO == 1 && m.CIDMOVTOOWNER == idMovimientoOwner);
    }
}
