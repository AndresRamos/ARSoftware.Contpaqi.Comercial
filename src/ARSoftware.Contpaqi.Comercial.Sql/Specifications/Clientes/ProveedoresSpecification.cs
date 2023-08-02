﻿using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

/// <summary>
///     Especificación para obtener proveedores.
/// </summary>
public sealed class ProveedoresSpecification : Specification<admClientes>
{
    public ProveedoresSpecification()
    {
        Query.Where(cliente =>
            cliente.CTIPOCLIENTE == (int)TipoCliente.Proveedor || cliente.CTIPOCLIENTE == (int)TipoCliente.ClienteProveedor);
    }
}
