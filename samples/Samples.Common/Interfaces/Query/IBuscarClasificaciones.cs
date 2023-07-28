using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Samples.Common;

public interface IBuscarClasificaciones
{
    void BuscarPorId(int idClasificacion);
    void BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);
    void TraerPorTipo(TipoClasificacion tipoClasificacion);
    void TraerTodo();
}