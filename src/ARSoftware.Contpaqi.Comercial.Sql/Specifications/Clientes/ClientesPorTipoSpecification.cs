using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;

/// <summary>
///     Especificación para obtener clientes por tipo.
/// </summary>
public sealed class ClientesPorTipoSpecification : Specification<admClientes>
{
    public ClientesPorTipoSpecification(TipoCliente tipoCliente)
    {
        Query.Where(cliente => cliente.CTIPOCLIENTE == (int)tipoCliente);
    }
}
