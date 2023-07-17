using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IUnidadMedidaRepository<T> where T : class, new()
    {
        T BuscarPorId(int idUnidad);
        T BuscarPorNombre(string nombreUnidad);
        IEnumerable<T> TraerTodo();
    }
}