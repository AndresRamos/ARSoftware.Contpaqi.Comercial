namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarMovimientos
{
    void BuscarPorId(int idMovimiento);
    void TraerPorDocumentoId(int idDocumento);
    void TraerTodo();
}