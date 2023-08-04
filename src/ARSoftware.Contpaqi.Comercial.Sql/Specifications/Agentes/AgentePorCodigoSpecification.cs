using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Agentes;

/// <summary>
///     Especificación para obtener un agente por su código.
/// </summary>
public sealed class AgentePorCodigoSpecification : SingleResultSpecification<admAgentes>
{
    public AgentePorCodigoSpecification(string codigoAgente)
    {
        Query.Where(agente => agente.CCODIGOAGENTE == codigoAgente);
    }
}
