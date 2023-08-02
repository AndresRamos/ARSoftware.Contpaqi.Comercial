using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;

/// <summary>
///     Especificación para obtener las direcciones por tipo de catálogo.
/// </summary>
public sealed class DireccionPorTipoCatalogoSpecification : Specification<admDomicilios>
{
    public DireccionPorTipoCatalogoSpecification(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion);
    }
}
