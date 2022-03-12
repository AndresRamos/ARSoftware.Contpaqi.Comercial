using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClasificacionRepository<T> where T : class, new()
    {
        T BuscarPorId(int idClasificacion);
        T BuscarPorTipoYNumero(TipoClasificacion tipo, NumeroClasificacion numero);
        IEnumerable<T> TraerPorTipo(TipoClasificacion tipo);
        IEnumerable<T> TraerTodo();
    }
}
