namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarAlmacenes
{
    void BuscarPorCodigo(string codigoAlmacen);
    void BuscarPorId(int idAlmacen);
    void TraerTodo();
}