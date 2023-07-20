using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class ProductoPorCodigoSpecification : SingleResultSpecification<admProductos>
{
    public ProductoPorCodigoSpecification(string codigoProducto)
    {
        Query.Where(producto => producto.CCODIGOPRODUCTO == codigoProducto);
    }
}

public sealed class ProductoPorIdSpecification : SingleResultSpecification<admProductos>
{
    public ProductoPorIdSpecification(int idProducto)
    {
        Query.Where(producto => producto.CIDPRODUCTO == idProducto);
    }
}

public sealed class ProductosPorTipoSpecification : Specification<admProductos>
{
    public ProductosPorTipoSpecification(TipoProducto tipoProducto)
    {
        Query.Where(producto => producto.CTIPOPRODUCTO == (int)tipoProducto);
    }
}