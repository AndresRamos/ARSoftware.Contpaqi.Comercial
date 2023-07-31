using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IClasificacionService
{
    void Actualizar(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        Dictionary<string, string> datosClasificacion);

    void Actualizar(int idClasificacion, Dictionary<string, string> datosClasificacion);
}
