using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IAlmacenRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoAlmacen);
        T BuscarPorId(int idAlmacen);
        IEnumerable<T> TraerTodo();
    }
}