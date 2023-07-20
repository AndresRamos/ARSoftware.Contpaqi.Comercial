using System;
using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

// ReSharper disable CompareOfFloatsByEqualityOperator

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class DocumentoPorIdSpecification : SingleResultSpecification<admDocumentos>
{
    public DocumentoPorIdSpecification(int idDocumento)
    {
        Query.Where(documento => documento.CIDDOCUMENTO == idDocumento);
    }
}

public sealed class DocumentoPorLlaveSpecification : SingleResultSpecification<admDocumentos>
{
    public DocumentoPorLlaveSpecification(int idConcepto, string serie, double folio)
    {
        Query.Where(documento =>
            documento.CIDCONCEPTODOCUMENTO == idConcepto && documento.CSERIEDOCUMENTO == serie && documento.CFOLIO == folio);
    }
}

public sealed class DocumentosPorRangoFechaYCodigoConceptoYCodigoClienteProveedor : Specification<admDocumentos>
{
    public DocumentosPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, int idConcepto,
        int idCliente)
    {
        Query.Where(documento => documento.CFECHA >= fechaInicio &&
                                 documento.CFECHA <= fechaFin &&
                                 documento.CIDCONCEPTODOCUMENTO == idConcepto &&
                                 documento.CIDCLIENTEPROVEEDOR == idCliente);
    }
}