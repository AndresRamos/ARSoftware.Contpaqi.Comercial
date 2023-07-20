using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class DireccionPorClienteSpecification : SingleResultSpecification<admDomicilios>
{
    public DireccionPorClienteSpecification(int idCliente, TipoDireccion tipoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Clientes &&
                                 direccion.CIDCATALOGO == idCliente &&
                                 direccion.CTIPODIRECCION == (int)tipoDireccion);
    }
}

public sealed class DireccionPorDocumentoSpecification : SingleResultSpecification<admDomicilios>
{
    public DireccionPorDocumentoSpecification(int idDocumento, TipoDireccion tipoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)TipoCatalogoDireccion.Documentos &&
                                 direccion.CIDCATALOGO == idDocumento &&
                                 direccion.CTIPODIRECCION == (int)tipoDireccion);
    }
}

public sealed class DireccionPorIdSpecification : SingleResultSpecification<admDomicilios>
{
    public DireccionPorIdSpecification(int idDireccion)
    {
        Query.Where(direccion => direccion.CIDDIRECCION == idDireccion);
    }
}

public sealed class DireccionPorTipoCatalogoSpecification : Specification<admDomicilios>
{
    public DireccionPorTipoCatalogoSpecification(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion);
    }
}

public sealed class DireccionPorTipoCatalogoYIdCatalogoSpecification : Specification<admDomicilios>
{
    public DireccionPorTipoCatalogoYIdCatalogoSpecification(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        Query.Where(direccion => direccion.CTIPOCATALOGO == (int)tipoCatalogoDireccion && direccion.CIDCATALOGO == idCatalogo);
    }
}