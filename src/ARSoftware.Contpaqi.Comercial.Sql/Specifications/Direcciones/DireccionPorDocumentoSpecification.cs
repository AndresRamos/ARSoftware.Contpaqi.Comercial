using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Direcciones;

/// <summary>
///     Especificación para obtener una dirección por documento.
/// </summary>
public sealed class DireccionPorDocumentoSpecification : SingleResultSpecification<admDomicilios>
{
    public DireccionPorDocumentoSpecification(int idDocumento, TipoDireccion tipoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Documentos &&
                                 direccion.CIDCATALOGO == idDocumento &&
                                 direccion.CTIPODIRECCION == (int)tipoDireccion);
    }
}
