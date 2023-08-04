using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Almacenes;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar almacenes.
/// </summary>
public sealed class AlmacenSqlRepository : ContpaqiComercialSqlRepositoryBase<admAlmacenes>, IAlmacenRepository<admAlmacenes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AlmacenSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAlmacenes? BuscarPorCodigo(string codigoAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorCodigoSpecification(codigoAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admAlmacenes? BuscarPorId(int idAlmacen)
    {
        return _context.admAlmacenes.WithSpecification(new AlmacenPorIdSpecification(idAlmacen)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admAlmacenes> TraerTodo()
    {
        return _context.admAlmacenes.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar almacenes y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los almacenes.
/// </typeparam>
public class AlmacenSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admAlmacenes, T>, IAlmacenRepository<T> where T : class, new()
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
}
