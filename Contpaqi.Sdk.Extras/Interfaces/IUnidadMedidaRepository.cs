using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IUnidadMedidaRepository<T> where T : class, new()
    {
        T BuscarPorId(int idUnidad);
        T BuscarPorNombre(string nombreUnidad);
        IEnumerable<T> TraerTodo();
    }
}
