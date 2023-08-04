namespace Samples.Common;

public interface IBuscarDocumentos
{
    void BuscarPorConceptoSerieFolio();
    void BuscarPorId();
    void BuscarPorLlave();
    void BuscarSiguienteSerieYFolio();
    void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor();
    void TraerTodo();
}
