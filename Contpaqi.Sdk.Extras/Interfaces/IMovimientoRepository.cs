using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IMovimientoRepository<T> where T : IMovimiento
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByDocumentoId(int idDocumento);
    }
}