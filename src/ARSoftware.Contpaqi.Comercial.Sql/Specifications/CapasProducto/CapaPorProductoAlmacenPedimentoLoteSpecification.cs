using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.CapasProducto;

/// <summary>
///     Especificación para obtener una capa de producto por producto, almacen, pedimento y lote.
/// </summary>
public sealed class CapaPorProductoAlmacenPedimentoLoteSpecification : Specification<admCapasProducto>
{
    public CapaPorProductoAlmacenPedimentoLoteSpecification(int idProducto, int idAlmacen, string numeroPedimento, string numerLote)
    {
        Query.Where(c => c.CIDPRODUCTO == idProducto && c.CIDALMACEN == idAlmacen && c.CPEDIMENTO == numeroPedimento &&
                         c.CNUMEROLOTE == numerLote);
    }
}
