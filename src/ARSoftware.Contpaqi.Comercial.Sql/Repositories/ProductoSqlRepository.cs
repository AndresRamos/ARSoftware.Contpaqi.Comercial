using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ProductoSqlRepository : RepositoryBase<admProductos>, IProductoRepository<admProductos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ProductoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admProductos? BuscarPorCodigo(string codigoProducto)
    {
        return _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admProductos? BuscarPorId(int idProducto)
    {
        return _context.admProductos.WithSpecification(new ProductoPorIdSpecification(idProducto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admProductos> TraerPorTipo(TipoProducto tipoProducto)
    {
        return _context.admProductos.WithSpecification(new ProductosPorTipoSpecification(tipoProducto)).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admProductos> TraerTodo()
    {
        return _context.admProductos.ToList();
    }
}