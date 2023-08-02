using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;

/// <summary>
///     Especificación para obtener las direcciones por tipo de catálogo y id de catálogo.
/// </summary>
public sealed class DireccionPorTipoCatalogoYIdCatalogoSpecification : Specification<admDomicilios>
{
    public DireccionPorTipoCatalogoYIdCatalogoSpecification(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion && direccion.CIDCATALOGO == idCatalogo);
    }
}
