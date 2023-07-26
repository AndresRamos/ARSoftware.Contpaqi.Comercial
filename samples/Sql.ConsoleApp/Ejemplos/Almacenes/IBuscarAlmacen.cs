namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarAlmacen
{
    void BuscarPorCodigo(string codigo);
    void BuscarPorId(int id);
    void TraerTodo();
}