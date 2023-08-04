using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar productos.
/// </summary>
public sealed class ProductoSqlRepository : ContpaqiComercialSqlRepositoryBase<admProductos>, IProductoRepository<admProductos>
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
    public List<admProductos> TraerPorTipo(TipoProducto tipoProducto)
    {
        return _context.admProductos.WithSpecification(new ProductosPorTipoSpecification(tipoProducto)).ToList();
    }

    /// <inheritdoc />
    public List<admProductos> TraerTodo()
    {
        return _context.admProductos.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar productos y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los productos.
/// </typeparam>
public sealed class ProductoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admProductos, T>, IProductoRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public ProductoSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoProducto)
    {
        return _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idProducto)
    {
        return _context.admProductos.WithSpecification(new ProductoPorIdSpecification(idProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoProducto tipoProducto)
    {
        return _context.admProductos.WithSpecification(new ProductosPorTipoSpecification(tipoProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admProductos.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
