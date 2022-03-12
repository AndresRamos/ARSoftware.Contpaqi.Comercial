using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDocumentoModeloRepository<T> where T : class, new()
    {
        IEnumerable<T> TraerTodo();
    }
}
