using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IValorClasificacionRepository<T> where T : class, new()
    {
        T BuscarPorId(int idValorClasificacion);

        T BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
            string codigoValorClasificacion);

        IEnumerable<T> TraerPorClasificacionId(int idClasificacion);
        IEnumerable<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);
        IEnumerable<T> TraerTodo();
    }
}