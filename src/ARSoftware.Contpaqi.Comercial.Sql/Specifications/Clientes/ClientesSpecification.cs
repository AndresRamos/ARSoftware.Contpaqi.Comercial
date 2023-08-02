﻿using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

/// <summary>
///     Especificación para obtener clientes.
/// </summary>
public sealed class ClientesSpecification : Specification<admClientes>
{
    public ClientesSpecification()
    {
        Query.Where(cliente =>
            cliente.CTIPOCLIENTE == (int)TipoCliente.Cliente || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor);
    }
}
