namespace Samples.Common;

public interface IBuscarConceptosDocumento
{
    void BuscarPorCodigo(string codigoConcepto);
    void BuscarPorId(int idConcepto);
    void TraerPorDocumentoModeloId(int idDocumentoModelo);
    void TraerTodo();
}