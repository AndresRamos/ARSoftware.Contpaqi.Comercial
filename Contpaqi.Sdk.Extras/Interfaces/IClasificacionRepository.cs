using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClasificacionRepository<T> where T : IClasificacion
    {
        T BuscarPorTipoYNumero(TipoClasificacionEnum tipo, int numero);
        T BuscarPorId(int idClasificacion);
        IEnumerable<T> TraerPorTipo(TipoClasificacionEnum tipo);
        IEnumerable<T> TraerTodo();
    }
}