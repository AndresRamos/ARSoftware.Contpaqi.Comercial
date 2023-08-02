using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar documentos modelo.
/// </summary>
public class DocumentoModeloRepository : IDocumentoModeloRepository<DocumentoModelo>
{
    /// <inheritdoc />
    public List<DocumentoModelo> TraerTodo()
    {
        return DocumentoModeloEnum.List.Select(d => new DocumentoModelo { Id = d.Value, Descripcion = d.Name }).ToList();
    }
}
