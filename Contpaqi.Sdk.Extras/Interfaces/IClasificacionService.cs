using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IClasificacionService
    {
        void Actualizar(TipoClasificacion tipoClasificacion,
                        NumeroClasificacion numeroClasificacion,
                        Dictionary<string, string> datosClasificacion);

        void Actualizar(int idClasificacion, Dictionary<string, string> datosClasificacion);
    }
}
