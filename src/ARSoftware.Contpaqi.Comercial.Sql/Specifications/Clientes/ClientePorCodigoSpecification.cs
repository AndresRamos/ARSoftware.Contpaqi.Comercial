using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clientes;

/// <summary>
///     Especificación para obtener un cliente por su código.
/// </summary>
public sealed class ClientePorCodigoSpecification : SingleResultSpecification<admClientes>
{
    public ClientePorCodigoSpecification(string codigoCliente)
    {
        Query.Where(cliente => cliente.CCODIGOCLIENTE == codigoCliente);
    }
}
