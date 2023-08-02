using System;
using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Documentos;

/// <summary>
///     Especificación para obtener documentos por rango de fecha, concepto y cliente.
/// </summary>
public sealed class DocumentosPorRangoFechaYConceptoYClienteSpecification : Specification<admDocumentos>
{
    public DocumentosPorRangoFechaYConceptoYClienteSpecification(DateTime fechaInicio, DateTime fechaFin, int idConcepto, int idCliente)
    {
        Query.Where(documento => documento.CFECHA >= fechaInicio &&
                                 documento.CFECHA <= fechaFin &&
                                 documento.CIDCONCEPTODOCUMENTO == idConcepto &&
                                 documento.CIDCLIENTEPROVEEDOR == idCliente);
    }
}
