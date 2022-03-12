using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteRepository<T> where T : class, new()
    {
        T BuscarPorCodigo(string codigoAgente);
        T BuscarPorId(int idAgente);
        IEnumerable<T> TraerTodo();
    }
}
