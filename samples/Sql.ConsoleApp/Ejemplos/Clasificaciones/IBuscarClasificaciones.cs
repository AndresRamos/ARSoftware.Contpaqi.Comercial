using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarClasificaciones
{
    void BuscarPorId(int idClasificacion);
    void BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);
    void TraerPorTipo(TipoClasificacion tipoClasificacion);
    void TraerTodo();
}