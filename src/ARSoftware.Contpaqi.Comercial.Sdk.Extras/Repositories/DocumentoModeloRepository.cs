using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar documentos modelo.
/// </summary>
public class DocumentoModeloRepository : IDocumentoModeloRepository<DocumentoModelo>
{
    /// <inheritdoc />
    public IEnumerable<DocumentoModelo> TraerTodo()
    {
        return DocumentoModelo.ToList();
    }
}