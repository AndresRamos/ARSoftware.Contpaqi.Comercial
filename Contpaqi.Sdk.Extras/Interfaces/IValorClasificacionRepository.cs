using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IValorClasificacionRepository<T> where T : IValorClasificacion
    {
        T BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacionEnum tipoClasificacion, int numeroClasificacion, string codigoValorClasificacion);
        T BuscarPorId(int idValorClasificacion);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorClasificacionId(int idClasificacion);
    }
}