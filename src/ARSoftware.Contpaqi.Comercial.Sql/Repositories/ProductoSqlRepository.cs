using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ProductoSqlRepository : IProductoRepository<admProductos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ProductoSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admProductos BuscarPorCodigo(string codigoProducto)
    {
        return _context.admProductos.SingleOrDefault(producto => producto.CCODIGOPRODUCTO == codigoProducto);
    }

    /// <inheritdoc />
    public admProductos BuscarPorId(int idProducto)
    {
        return _context.admProductos.SingleOrDefault(producto => producto.CIDPRODUCTO == idProducto);
    }

    /// <inheritdoc />
    public IEnumerable<admProductos> TraerPorTipo(TipoProducto tipoProducto)
    {
        return _context.admProductos.Where(producto => producto.CTIPOPRODUCTO == (int)tipoProducto).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admProductos> TraerTodo()
    {
        return _context.admProductos.ToList();
    }
}