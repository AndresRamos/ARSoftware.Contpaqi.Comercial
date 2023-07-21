using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

public interface IEmpresaRepository<T> where T : class, new()
{
    IEnumerable<T> TraerTodo();
}