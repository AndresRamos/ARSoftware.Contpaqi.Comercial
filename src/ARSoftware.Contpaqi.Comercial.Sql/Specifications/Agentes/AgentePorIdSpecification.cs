using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Agentes;

/// <summary>
///     Especificación para obtener un agente por su id.
/// </summary>
public sealed class AgentePorIdSpecification : SingleResultSpecification<admAgentes>
{
    public AgentePorIdSpecification(int idAgente)
    {
        Query.Where(agente => agente.CIDAGENTE == idAgente);
    }
}
