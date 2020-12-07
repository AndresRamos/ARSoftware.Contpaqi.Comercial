using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IMonedaRepository<T> where T : IMoneda
    {
        T BuscarPorNombre(string nombreMoneda);
        T BuscarPorId(int idMoneda);
        IEnumerable<T> TraerTodo();
    }
}