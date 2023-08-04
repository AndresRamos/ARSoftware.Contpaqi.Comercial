using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar clasificaciones.
/// </summary>
public sealed class ClasificacionSqlRepository : ContpaqiComercialSqlRepositoryBase<admClasificaciones>,
    IClasificacionRepository<admClasificaciones>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificaciones? BuscarPorId(int idClasificacion)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionPorIdSpecification(idClasificacion)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admClasificaciones? BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        return _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admClasificaciones> TraerPorTipo(TipoClasificacion tipoClasificacion)
    {
        return _context.admClasificaciones.WithSpecification(new ClasificacionesPorTipoSpecification(tipoClasificacion)).ToList();
    }

    /// <inheritdoc />
    public List<admClasificaciones> TraerTodo()
    {
        return _context.admClasificaciones.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar clasificaciones y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las clasificaciones.
/// </typeparam>
public class ClasificacionSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClasificaciones, T>, IClasificacionRepository<T>
    where T : class, new()
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
}
