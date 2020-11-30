using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAlmacenRepository<T> where T : IAlmacen
    {
        T BuscarPorId(int idAlmacen);
        T BuscarPorCodigo(string codigoAlmacen);
        IEnumerable<T> TraerTodo();
    }
}