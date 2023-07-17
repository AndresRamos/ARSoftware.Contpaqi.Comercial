using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IMovimientoRepository<T> where T : class, new()
    {
        T BuscarPorId(int idMovimiento);
        IEnumerable<T> TraerPorDocumentoId(int idDocumento);
        IEnumerable<T> TraerTodo();
    }
}