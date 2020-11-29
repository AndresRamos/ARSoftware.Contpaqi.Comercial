using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IAlmacenRepository<T> where T : IAlmacen
    {
        T FindById(int idAlmacen);
        T FindByCodigo(string codigoAlmacen);
        IEnumerable<T> GetAll();
    }
}