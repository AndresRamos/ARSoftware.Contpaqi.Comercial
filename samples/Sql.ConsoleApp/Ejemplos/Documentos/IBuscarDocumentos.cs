using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace Sql.ConsoleApp.Ejemplos;

public interface IBuscarDocumentos
{
    void BuscarPorId(int idDocumento);
    void BuscarPorLlave(string codigoConcepto, string serie, double folio);
    void BuscarPorLlave(LlaveDocumento llaveDocumento);
    void BuscarSiguienteSerieYFolio(string codigoConcepto);

    void TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto,
        string codigoClienteProveedor);

    void TraerTodo();
}