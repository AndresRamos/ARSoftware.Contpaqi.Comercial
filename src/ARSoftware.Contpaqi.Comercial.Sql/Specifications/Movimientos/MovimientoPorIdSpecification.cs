using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;

/// <summary>
///     Especificación para obtener un movimiento por su id.
/// </summary>
public sealed class MovimientoPorIdSpecification : SingleResultSpecification<admMovimientos>
{
    public MovimientoPorIdSpecification(int idMovimiento)
    {
        Query.Where(movimiento => movimiento.CIDMOVIMIENTO == idMovimiento);
    }
}
