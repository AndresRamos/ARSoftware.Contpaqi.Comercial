using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

/// <summary>
///     Especificación para obtener un cliente por su id.
/// </summary>
public sealed class ClientePorIdSpecification : SingleResultSpecification<admClientes>
{
    public ClientePorIdSpecification(int idCliente)
    {
        Query.Where(cliente => cliente.CIDCLIENTEPROVEEDOR == idCliente);
    }
}