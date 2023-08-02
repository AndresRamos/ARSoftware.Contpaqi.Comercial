using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;

/// <summary>
///     Especificación para obtener los productos por tipo.
/// </summary>
public sealed class ProductosPorTipoSpecification : Specification<admProductos>
{
    public ProductosPorTipoSpecification(TipoProducto tipoProducto)
    {
        Query.Where(producto => producto.CTIPOPRODUCTO == (int)tipoProducto);
    }
}
