using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class AgenteSqlRepository : IAgenteRepository<admAgentes>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public AgenteSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admAgentes BuscarPorCodigo(string codigoAgente)
    {
        return _context.admAgentes.SingleOrDefault(agente => agente.CCODIGOAGENTE == codigoAgente);
    }

    /// <inheritdoc />
    public admAgentes BuscarPorId(int idAgente)
    {
        return _context.admAgentes.SingleOrDefault(agente => agente.CIDAGENTE == idAgente);
    }

    /// <inheritdoc />
    public IEnumerable<admAgentes> TraerTodo()
    {
        return _context.admAgentes.ToList();
    }
}