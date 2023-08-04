using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Movimientos;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar movimientos.
/// </summary>
public sealed class MovimientoSqlRepository : ContpaqiComercialSqlRepositoryBase<admMovimientos>, IMovimientoRepository<admMovimientos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MovimientoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMovimientos? BuscarPorId(int idMovimiento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientoPorIdSpecification(idMovimiento)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admMovimientos> TraerPorDocumentoId(int idDocumento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientosPorDocumentoIdSpecification(idDocumento)).ToList();
    }

    /// <inheritdoc />
    public List<admMovimientos> TraerTodo()
    {
        return _context.admMovimientos.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar movimientos y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los movimientos.
/// </typeparam>
public sealed class MovimientoSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admMovimientos, T>, IMovimientoRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public MovimientoSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idMovimiento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientoPorIdSpecification(idMovimiento))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorDocumentoId(int idDocumento)
    {
        return _context.admMovimientos.WithSpecification(new MovimientosPorDocumentoIdSpecification(idDocumento))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admMovimientos.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
