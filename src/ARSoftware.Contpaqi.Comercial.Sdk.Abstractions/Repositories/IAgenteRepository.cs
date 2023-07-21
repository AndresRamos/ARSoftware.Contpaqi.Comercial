using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

public interface IAgenteRepository<T> where T : class, new()
{
    T? BuscarPorCodigo(string codigoAgente);
    T? BuscarPorId(int idAgente);
    IEnumerable<T> TraerTodo();
}