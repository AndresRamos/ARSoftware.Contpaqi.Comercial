using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IConceptoDocumentoRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoConcepto);
        T BuscarPorId(int idConcepto);
        IEnumerable<T> TraerPorDocumentoModeloId(int documentoModeloId);
        IEnumerable<T> TraerTodo();
    }
}