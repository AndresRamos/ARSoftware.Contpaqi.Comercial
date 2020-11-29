using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IUnidadMedidaRepository<T> where T : IUnidadMedida
    {
        T FindByNombre(string nombreUnidad);
        T FindById(int idUnidad);
        IEnumerable<T> GetAll();
    }
}