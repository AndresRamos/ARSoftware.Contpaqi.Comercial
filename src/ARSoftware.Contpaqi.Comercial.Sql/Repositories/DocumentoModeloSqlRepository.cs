using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sql.Contexts;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Repositories;

public sealed class DocumentoModeloSqlRepository : IDocumentoModeloRepository<admDocumentosModelo>
{
    private readonly ContpaqiComercialEmpresaDbContext _context;

    public DocumentoModeloSqlRepository(ContpaqiComercialEmpresaDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public IEnumerable<admDocumentosModelo> TraerTodo()
    {
        return _context.admDocumentosModelo.ToList();
    }
}