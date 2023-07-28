namespace Samples.Common;

public interface IBuscarMonedas
{
    void BuscarPorId(int idMoneda);
    void BuscarPorNombre(string nombreMoneda);
    void TraerTodo();
}