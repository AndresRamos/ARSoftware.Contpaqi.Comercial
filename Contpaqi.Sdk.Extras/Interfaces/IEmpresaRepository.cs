using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IEmpresaRepository<T> where T : class, new()
    {
        IEnumerable<T> TraerTodo();
    }
}
