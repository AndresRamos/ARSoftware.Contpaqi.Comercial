﻿using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

/// <summary>
///     Especificación para obtener agentes por su tipo.
/// </summary>
public sealed class AgentePorTipoSpecification : Specification<admAgentes>
{
    public AgentePorTipoSpecification(TipoAgente tipoAgente)
    {
        Query.Where(agente => agente.CTIPOAGENTE == (int)tipoAgente);
    }
}
