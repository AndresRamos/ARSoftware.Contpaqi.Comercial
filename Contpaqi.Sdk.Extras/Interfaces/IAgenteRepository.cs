using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteRepository<T> where T : IAgente
    {
        T BuscarPorId(int idAgente);
        T BuscarPorCodigo(string codigoAgente);
        IEnumerable<T> TraerTodo();
    }
}