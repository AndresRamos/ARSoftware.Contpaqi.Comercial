using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Repositories.Common;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications.Agentes;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar agentes.
/// </summary>
public sealed class AgenteSqlRepository : ContpaqiComercialSqlRepositoryBase<admAgentes>, IAgenteRepository<admAgentes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AgenteSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAgentes? BuscarPorCodigo(string codigoAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorCodigoSpecification(codigoAgente)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admAgentes? BuscarPorId(int idAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorIdSpecification(idAgente)).SingleOrDefault();
    }

    /// <inheritdoc />
    public List<admAgentes> TraerPorTipo(TipoAgente tipoAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorTipoSpecification(tipoAgente)).ToList();
    }

    /// <inheritdoc />
    public List<admAgentes> TraerTodo()
    {
        return _context.admAgentes.ToList();
    }
}

/// <summary>
///     Repositorio de SQL para consultar agentes y transformarlos a un tipo destino utilizando AutoMapper.
/// </summary>
/// <typeparam name="T">
///     Tipo del objecto destino al que se mapean los agentes.
/// </typeparam>
public class AgenteSqlRepository<T> : ContpaqiComercialSqlRepositoryBase<admAgentes, T>, IAgenteRepository<T> where T : class, new()
{
    private readonly ContpaqiComercialEmpresaDbContext _context;
    private readonly IMapper _mapper;

    public AgenteSqlRepository(ContpaqiComercialEmpresaDbContext context, IMapper mapper) : base(context, mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorCodigoSpecification(codigoAgente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorIdSpecification(idAgente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .SingleOrDefault();
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoAgente tipoAgente)
    {
        return _context.admAgentes.WithSpecification(new AgentePorTipoSpecification(tipoAgente))
            .ProjectTo<T>(_mapper.ConfigurationProvider)
            .ToList();
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        return _context.admAgentes.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
    }
}
