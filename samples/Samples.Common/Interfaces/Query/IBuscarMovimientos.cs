namespace Samples.Common;

public interface IBuscarMovimientos
{
    void BuscarPorId(int idMovimiento);
    void TraerPorDocumentoId(int idDocumento);
    void TraerTodo();
}