using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class ClientePorCodigoSpecification : SingleResultSpecification<admClientes>
{
    public ClientePorCodigoSpecification(string codigoCliente)
    {
        Query.Where(cliente => cliente.CCODIGOCLIENTE == codigoCliente);
    }
}

public sealed class ClientePorIdSpecification : SingleResultSpecification<admClientes>
{
    public ClientePorIdSpecification(int idCliente)
    {
        Query.Where(cliente => cliente.CIDCLIENTEPROVEEDOR == idCliente);
    }
}

public sealed class ClientesSpecification : Specification<admClientes>
{
    public ClientesSpecification()
    {
        Query.Where(cliente =>
            cliente.CTIPOCLIENTE == (int)TipoCliente.Cliente || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor);
    }
}

public sealed class ClientesPorTipoSpecification : Specification<admClientes>
{
    public ClientesPorTipoSpecification(TipoCliente tipoCliente)
    {
        Query.Where(cliente => cliente.CTIPOCLIENTE == (int)tipoCliente);
    }
}

public sealed class ProveedoresSpecification : Specification<admClientes>
{
    public ProveedoresSpecification()
    {
        Query.Where(cliente =>
            cliente.CTIPOCLIENTE == (int)TipoCliente.Proveedor || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor);
    }
}