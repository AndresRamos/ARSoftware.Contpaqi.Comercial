using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar agentes.
/// </summary>
public sealed class AgenteSqlRepository : RepositoryBase<admAgentes>, IAgenteRepository<admAgentes>
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
    public IEnumerable<admAgentes> TraerTodo()
    {
        return _context.admAgentes.ToList();
    }
}