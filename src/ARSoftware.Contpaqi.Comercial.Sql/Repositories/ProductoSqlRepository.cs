using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Productos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar productos y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los productos.
/// </typeparam>
public sealed class ProductoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admProductos, T>, IProductoSqlRepository<T>
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

    /// <inheritdoc />
    public async Task<T?> BuscarPorCodigoAsync(string codigoProducto, CancellationToken cancellationToken)
    {
        return await _context.admProductos.WithSpecification(new ProductoPorCodigoSpecification(codigoProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idProducto, CancellationToken cancellationToken)
    {
        return await _context.admProductos.WithSpecification(new ProductoPorIdSpecification(idProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorTipoAsync(TipoProducto tipoProducto, CancellationToken cancellationToken)
    {
        return await _context.admProductos.WithSpecification(new ProductosPorTipoSpecification(tipoProducto))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admProductos.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
