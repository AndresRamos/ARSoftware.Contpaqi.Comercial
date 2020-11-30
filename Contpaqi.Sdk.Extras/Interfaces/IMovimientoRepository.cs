using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IMovimientoRepository<T> where T : IMovimiento
    {
        T BuscarPorId(int idMovimiento);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorDocumentoId(int idDocumento);
    }
}