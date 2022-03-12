using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IMonedaRepository<T> where T : class, new()
    {
        T BuscarPorId(int idMoneda);
        T BuscarPorNombre(string nombreMoneda);
        IEnumerable<T> TraerTodo();
    }
}
