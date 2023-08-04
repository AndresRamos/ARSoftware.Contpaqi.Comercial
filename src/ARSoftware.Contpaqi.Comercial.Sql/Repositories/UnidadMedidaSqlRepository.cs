using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.UnidadesMedida;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar unidades de medida.
/// </summary>
public sealed class UnidadMedidaSqlRepository : ContpaqiComercialSqlRepositoryBase<admUnidadesMedidaPeso>,
    IUnidadMedidaRepository<admUnidadesMedidaPeso>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public UnidadMedidaSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso? BuscarPorId(int idUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorIdSpecification(idUnidad)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admUnidadesMedidaPeso? BuscarPorNombre(string nombreUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorNombreSpecification(nombreUnidad)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admUnidadesMedidaPeso> TraerTodo()
    {
        return _context.admUnidadesMedidaPeso.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar unidades de medida y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las unidades de medida.
/// </typeparam>
public sealed class UnidadMedidaSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admUnidadesMedidaPeso, T>, IUnidadMedidaRepository<T>
    where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public UnidadMedidaSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorIdSpecification(idUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreUnidad)
    {
        return _context.admUnidadesMedidaPeso.WithSpecification(new UnidadMedidaPorNombreSpecification(nombreUnidad))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admUnidadesMedidaPeso.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
