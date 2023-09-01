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
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar clasificaciones y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las clasificaciones.
/// </typeparam>
public sealed class ClasificacionSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClasificaciones, T>,
    IClasificacionSqlRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    /// <inheritdoc />
    public ClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idClasificacion)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionPorIdSpecification(idClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        return _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoClasificacion tipoClasificacion)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionesPorTipoSpecification(tipoClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admClasificaciones.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsyc(int idClasificacion, CancellationToken cancellationToken)
    {
        return await _context.admClasificaciones.WithSpecification(new ClasificacionPorIdSpecification(idClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorTipoYNumeroAsync(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        CancellationToken cancellationToken)
    {
        return await _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorTipoAsync(TipoClasificacion tipoClasificacion, CancellationToken cancellationToken)
    {
        return await _context.admClasificaciones.WithSpecification(new ClasificacionesPorTipoSpecification(tipoClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admClasificaciones.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
