using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Generales;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Empresas;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar empresas.
/// </summary>
public sealed class EmpresaSqlRepository : ContpaqiComercialSqlRepositoryBase<Empresas>, IEmpresaRepository<Empresas>
{
    private readonly ContpaqiComercialGeneralesDbContext _context;

    public EmpresaSqlRepository(ContpaqiComercialGeneralesDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public Empresas? BuscarPorNombre(string nombreEmpresa)
    {
        return _context.Empresas.WithSpecification(new EmpresaPorNombreSpecification(nombreEmpresa)).FirstOrDefault();
    }

    /// <inheritdoc />
    public List<Empresas> TraerTodo()
    {
        return _context.Empresas.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar empresas y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean las empresas.
/// </typeparam>
public sealed class EmpresaSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<Empresas, T>, IEmpresaRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialGeneralesDbContext _context;
    private readonly IMapper _mapper;

    public EmpresaSqlRepository(ContpaqiComercialGeneralesDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreEmpresa)
    {
        return _context.Empresas.WithSpecification(new EmpresaPorNombreSpecification(nombreEmpresa))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .FirstOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.Empresas.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
