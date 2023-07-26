namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarMonedas
{
    void BuscarPorId(int idMoneda);
    void BuscarPorNombre(string nombreMoneda);
    void TraerTodo();
}