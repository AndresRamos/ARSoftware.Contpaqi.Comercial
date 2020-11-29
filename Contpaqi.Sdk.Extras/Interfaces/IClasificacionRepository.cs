using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClasificacionRepository<T> where T : IClasificacion
    {
        T FindByTipoAndNumero(TipoClasificacionEnum tipo, int numero);
        T FindById(int idClasificacion);
        IEnumerable<T> GetAllByTipo(TipoClasificacionEnum tipo);
        IEnumerable<T> GetAll();
    }
}