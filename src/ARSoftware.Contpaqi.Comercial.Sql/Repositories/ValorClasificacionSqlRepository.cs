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
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresClasificacion;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar valores de clasificación y transformarlos a un tipo destino utilizando
///     AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los valores de clasificación.
/// </typeparam>
public sealed class ValorClasificacionSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClasificacionesValores, T>,
    IValorClasificacionSqlRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public ValorClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idValorClasificacion)
    {
        return _context.admClasificacionesValores.WithSpecification(new ValorClasificacionPorIdSpecification(idValorClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(
                new ValorClasificacionPorClasificacionIdYCodigoSpecification(clasificacion.CIDCLASIFICACION, codigoValorClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorClasificacionId(int idClasificacion)
    {
        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(idClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(clasificacion.CIDCLASIFICACION))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admClasificacionesValores.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorIdAsync(int idValorClasificacion, CancellationToken cancellationToken)
    {
        return await _context.admClasificacionesValores.WithSpecification(new ValorClasificacionPorIdSpecification(idValorClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<T?> BuscarPorTipoClasificacionNumeroYCodigoAsync(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion, string codigoValorClasificacion, CancellationToken cancellationToken)
    {
        admClasificaciones clasificacion = await _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .SingleAsync(cancellationToken);

        return await _context.admClasificacionesValores
            .WithSpecification(
                new ValorClasificacionPorClasificacionIdYCodigoSpecification(clasificacion.CIDCLASIFICACION, codigoValorClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorClasificacionIdAsync(int idClasificacion, CancellationToken cancellationToken)
    {
        return await _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(idClasificacion))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerPorClasificacionTipoYNumeroAsync(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion, CancellationToken cancellationToken)
    {
        admClasificaciones clasificacion = await _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .SingleAsync(cancellationToken);

        return await _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(clasificacion.CIDCLASIFICACION))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<List<T>> TraerTodoAsync(CancellationToken cancellationToken)
    {
        return await _context.admClasificacionesValores.ProjectTo<T>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }
}
