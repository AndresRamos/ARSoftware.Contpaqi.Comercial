using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ConceptoDocumentoSqlRepository : IConceptoDocumentoRepository<admConceptos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ConceptoDocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admConceptos BuscarPorCodigo(string codigoConcepto)
    {
        return _context.admConceptos.SingleOrDefault(concepto => concepto.CCODIGOCONCEPTO == codigoConcepto);
    }

    /// <inheritdoc />
    public admConceptos BuscarPorId(int idConcepto)
    {
        return _context.admConceptos.SingleOrDefault(concepto => concepto.CIDCONCEPTODOCUMENTO == idConcepto);
    }

    /// <inheritdoc />
    public IEnumerable<admConceptos> TraerPorDocumentoModeloId(int documentoModeloId)
    {
        return _context.admConceptos.Where(concepto => concepto.CIDDOCUMENTODE == documentoModeloId).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admConceptos> TraerTodo()
    {
        return _context.admConceptos.ToList();
    }
}