using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAgenteRepository<T> where T : IAgente
    {
        T FindById(int idAgente);
        T FindByCodigo(string codigoAgente);
        IEnumerable<T> GetAll();
    }
}