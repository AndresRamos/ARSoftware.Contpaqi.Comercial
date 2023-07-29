namespace Samples.Common;

public interface IBuscarDocumentos
{
    void BuscarPorId();
    void BuscarPorConceptoSerieFolio();
    void BuscarPorLlave();
    void BuscarSiguienteSerieYFolio();
    void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor();
    void TraerTodo();
}