using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarAgente
{
    void BuscarPorCodigo(string codigo);
    void BuscarPorId(int id);
    void BuscarPorTipo(TipoAgente tipo);
    void TraerTodo();
}