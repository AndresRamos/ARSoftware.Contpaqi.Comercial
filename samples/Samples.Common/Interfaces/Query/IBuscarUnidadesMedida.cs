namespace Samples.Common;

public interface IBuscarUnidadesMedida
{
    void BuscarPorId(int id);
    void BuscarPorNombre(string nombre);
    void TraerTodo();
}