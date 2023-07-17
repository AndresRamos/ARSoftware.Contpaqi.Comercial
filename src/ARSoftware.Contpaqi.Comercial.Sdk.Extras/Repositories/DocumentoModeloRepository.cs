using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class DocumentoModeloRepository : IDocumentoModeloRepository<DocumentoModelo>
    {
        public IEnumerable<DocumentoModelo> TraerTodo()
        {
            return DocumentoModelo.ToList();
        }
    }
}