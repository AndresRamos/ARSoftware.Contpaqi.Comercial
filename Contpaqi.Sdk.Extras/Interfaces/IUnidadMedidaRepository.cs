using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IUnidadMedidaRepository<T> where T : class, new()
    {
        T BuscarPorId(int idUnidad);
        T BuscarPorNombre(string nombreUnidad);
        IEnumerable<T> TraerTodo();
    }
}
