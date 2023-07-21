using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

public interface IDocumentoModeloRepository<T> where T : class, new()
{
    IEnumerable<T> TraerTodo();
}