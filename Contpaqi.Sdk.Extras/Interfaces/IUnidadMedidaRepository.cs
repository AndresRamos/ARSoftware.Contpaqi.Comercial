using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IUnidadMedidaRepository<T> where T : IUnidadMedida
    {
        T BuscarPorNombre(string nombreUnidad);
        T BuscarPorId(int idUnidad);
        IEnumerable<T> TraerTodo();
    }
}