using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;

/// <summary>
///     Especificación para obtener un producto por su id.
/// </summary>
public sealed class ProductoPorIdSpecification : SingleResultSpecification<admProductos>
{
    public ProductoPorIdSpecification(int idProducto)
    {
        Query.Where(producto => producto.CIDPRODUCTO == idProducto);
    }
}
