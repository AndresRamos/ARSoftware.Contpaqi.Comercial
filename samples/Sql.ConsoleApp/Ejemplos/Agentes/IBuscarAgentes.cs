using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarAgentes
{
    void BuscarPorCodigo(string codigoAgente);
    void BuscarPorId(int idAgente);
    void TraerPorTipo(TipoAgente tipoAgente);
    void TraerTodo();
}