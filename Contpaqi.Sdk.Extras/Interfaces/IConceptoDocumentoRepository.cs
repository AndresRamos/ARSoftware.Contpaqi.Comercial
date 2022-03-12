using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IConceptoDocumentoRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoConcepto);
        T BuscarPorId(int idConcepto);
        IEnumerable<T> TraerPorDocumentoModeloId(int documentoModeloId);
        IEnumerable<T> TraerTodo();
    }
}
