using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;

/// <summary>
///     Especificación para obtener las direcciones de un cliente.
/// </summary>
public sealed class DireccionesPorClienteSpecification : Specification<admDomicilios>
{
    public DireccionesPorClienteSpecification(int idCliente, TipoDireccion tipoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Clientes &&
                                 direccion.CIDCATALOGO == idCliente &&
                                 direccion.CTIPODIRECCION == (int)tipoDireccion);
    }
}
