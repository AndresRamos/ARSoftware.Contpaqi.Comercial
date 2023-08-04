using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;

/// <summary>
///     Especificación para obtener un producto por su código.
/// </summary>
public sealed class ProductoPorCodigoSpecification : SingleResultSpecification<admProductos>
{
    public ProductoPorCodigoSpecification(string codigoProducto)
    {
        Query.Where(producto => producto.CCODIGOPRODUCTO == codigoProducto);
    }
}
