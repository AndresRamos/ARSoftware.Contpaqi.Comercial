using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IEmpresaRepository<T> where T : class, new()
    {
        IEnumerable<T> TraerTodo();
    }
}
