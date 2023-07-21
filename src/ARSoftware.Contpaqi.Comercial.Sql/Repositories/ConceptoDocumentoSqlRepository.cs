using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using ARSoftware.Contpaqi.Comercial.Sql.Specifications;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class ConceptoDocumentoSqlRepository : RepositoryBase<admConceptos>, IConceptoDocumentoRepository<admConceptos>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public ConceptoDocumentoSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public admConceptos? BuscarPorCodigo(string codigoConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorCodigoSpecification(codigoConcepto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public admConceptos? BuscarPorId(int idConcepto)
    {
        return _context.admConceptos.WithSpecification(new ConceptoPorIdSpecification(idConcepto)).SingleOrDefault();
    }

    /// <inheritdoc />
    public IEnumerable<admConceptos> TraerPorDocumentoModeloId(int documentoModeloId)
    {
        return _context.admConceptos.WithSpecification(new ConceptosPorDocumentoModeloIdSpecification(documentoModeloId)).ToList();
    }

    /// <inheritdoc />
    public IEnumerable<admConceptos> TraerTodo()
    {
        return _context.admConceptos.ToList();
    }
}