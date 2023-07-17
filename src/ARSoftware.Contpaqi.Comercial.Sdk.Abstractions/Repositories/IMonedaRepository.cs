using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IMonedaRepository<T> where T : class, new()
    {
        T BuscarPorId(int idMoneda);
        T BuscarPorNombre(string nombreMoneda);
        IEnumerable<T> TraerTodo();
    }
}