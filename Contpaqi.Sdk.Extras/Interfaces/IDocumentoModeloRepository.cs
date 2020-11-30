using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDocumentoModeloRepository<T> where T : IDocumentoModelo
    {
        IEnumerable<T> TraerTodo();
    }
}