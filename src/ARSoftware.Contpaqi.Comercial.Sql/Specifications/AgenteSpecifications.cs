using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

/// <summary>
///     Busca un agente por su código.
/// </summary>
public sealed class AgentePorCodigoSpecification : SingleResultSpecification<admAgentes>
{
    public AgentePorCodigoSpecification(string codigoAgente)
    {
        Query.Where(agente => agente.CCODIGOAGENTE == codigoAgente);
    }
}

/// <summary>
///     Busca un agente por su id.
/// </summary>
public sealed class AgentePorIdSpecification : SingleResultSpecification<admAgentes>
{
    public AgentePorIdSpecification(int idAgente)
    {
        Query.Where(agente => agente.CIDAGENTE == idAgente);
    }
}