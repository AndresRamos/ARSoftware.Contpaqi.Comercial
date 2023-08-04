using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresClasificacion;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar valores de clasificación.
/// </summary>
public sealed class ValorClasificacionSqlRepository : ContpaqiComercialSqlRepositoryBase<admClasificacionesValores>,
    IValorClasificacionRepository<admClasificacionesValores>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ValorClasificacionSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admClasificacionesValores? BuscarPorId(int idValorClasificacion)
    {
        return _context.admClasificacionesValores.WithSpecification(new ValorClasificacionPorIdSpecification(idValorClasificacion))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public admClasificacionesValores? BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion, string codigoValorClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(
                new ValorClasificacionPorClasificacionIdYCodigoSpecification(clasificacion.CIDCLASIFICACION, codigoValorClasificacion))
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admClasificacionesValores> TraerPorClasificacionId(int idClasificacion)
    {
        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(idClasificacion))
            .ToList();
    }

    /// <inheritdoc />
    public List<admClasificacionesValores> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion,
        NumeroClasificacion numeroClasificacion)
    {
        admClasificaciones clasificacion = _context.admClasificaciones
            .WithSpecification(new ClasificacionPorTipoYNumeroSpecification(tipoClasificacion, numeroClasificacion))
            .Single();

        return _context.admClasificacionesValores
            .WithSpecification(new ValoresClasificacionPorClasificacionIdSpecification(clasificacion.CIDCLASIFICACION))
            .ToList();
    }

    /// <inheritdoc />
    public List<admClasificacionesValores> TraerTodo()
    {
        return _context.admClasificacionesValores.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar valores de clasificación y transformarlos a un tipo destino utilizando
///     AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los valores de clasificación.
/// </typeparam>
public sealed class ValorClasificacionSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admClasificacionesValores, T>,
    IValorClasificacionRepository<T> where T : class, new()
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
}
