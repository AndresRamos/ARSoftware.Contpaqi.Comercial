using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IValorClasificacionRepository<T> where T : IValorClasificacion
    {
        T FindByTipoClasificacionNumeroAndCodigo(TipoClasificacionEnum tipoClasificacion, int numeroClasificacion, string codigoValorClasificacion);
        T FindById(int idValorClasificacion);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByClasificacionId(int idClasificacion);
    }
}