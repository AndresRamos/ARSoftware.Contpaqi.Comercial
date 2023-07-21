using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification.EntityFrameworkCore;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

/// <summary>
///     Repositorio de SQL para consultar documentos modelo.
/// </summary>
public sealed class DocumentoModeloSqlRepository : RepositoryBase<admDocumentosModelo>, IDocumentoModeloRepository<admDocumentosModelo>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DocumentoModeloSqlRepository(ContpaqiComercialEmpresaDbContext context) : base(context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentosModelo> TraerTodo()
    {
        return _context.admDocumentosModelo.ToList();
    }
}