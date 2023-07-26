namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarUnidadesMedida
{
    void BuscarPorId(int id);
    void BuscarPorNombre(string nombre);
    void TraerTodo();
}