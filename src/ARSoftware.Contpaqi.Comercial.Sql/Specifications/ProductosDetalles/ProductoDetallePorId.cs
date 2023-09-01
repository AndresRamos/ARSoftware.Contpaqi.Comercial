using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.ProductosDetalles;

/// <summary>
///   Especificación para obtener un detalle de producto por su id.
/// </summary>
public sealed class ProductoDetallePorId : SingleResultSpecification<admProductosDetalles>
{
    public ProductoDetallePorId(int productoDetalleId)
    {
        Query.Where(productoDetalle => productoDetalle.CIDPRODUCTO == productoDetalleId);
    }
}
