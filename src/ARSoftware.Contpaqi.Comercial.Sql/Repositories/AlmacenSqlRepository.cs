using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Almacenes;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar almacenes y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los almacenes.
/// </typeparam>
public class AlmacenSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admAlmacenes, T>, IAlmacenSqlRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    /// <inheritdoc />
    public AlmacenSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorIdSpecification(idAlmacen))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admAlmacenes.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorCodigoAsync(string codigoAlmacen, CancellationToken cancellationToken)
    {
        return await _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idAlmacen, CancellationToken cancellationToken)
    {
        return await _context.admAlmacenes.WithSpecification(new AlmacenPorIdSpecification(idAlmacen))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admAlmacenes.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
