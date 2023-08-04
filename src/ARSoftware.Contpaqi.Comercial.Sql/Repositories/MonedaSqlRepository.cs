using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Monedas;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar monedas.
/// </summary>
public sealed class MonedaSqlRepository : ContpaqiComercialSqlRepositoryBase<admMonedas>, IMonedaRepository<admMonedas>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public MonedaSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admMonedas? BuscarPorId(int idMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorIdSpecification(idMoneda)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admMonedas? BuscarPorNombre(string nombreMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorNombreSpecification(nombreMoneda)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admMonedas> TraerTodo()
    {
        return _context.admMonedas.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar monedas y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las monedas.
/// </typeparam>
public sealed class MonedaSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admMonedas, T>, IMonedaRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public MonedaSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorIdSpecification(idMoneda))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreMoneda)
    {
        return _context.admMonedas.WithSpecification(new MonedaPorNombreSpecification(nombreMoneda))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admMonedas.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
