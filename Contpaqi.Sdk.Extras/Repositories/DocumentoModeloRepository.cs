using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class DocumentoModeloRepository : IDocumentoModeloRepository<DocumentoModelo>
    {
        public IEnumerable<DocumentoModelo> TraerTodo()
        {
            return DocumentoModelo.ToList();
        }
    }
}