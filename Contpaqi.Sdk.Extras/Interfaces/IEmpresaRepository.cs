using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IEmpresaRepository<T> where T : IEmpresa
    {
        IEnumerable<T> TraerTodo();
    }
}