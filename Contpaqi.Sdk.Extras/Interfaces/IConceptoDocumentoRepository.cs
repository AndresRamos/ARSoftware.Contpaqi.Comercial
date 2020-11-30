using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IConceptoDocumentoRepository<T> where T : IConceptoDocumento
    {
        T BuscarPorId(int idConcepto);
        T BuscarPorCodigo(string codigoConcepto);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorDocumentoModeloId(int documentoModeloId);
    }
}