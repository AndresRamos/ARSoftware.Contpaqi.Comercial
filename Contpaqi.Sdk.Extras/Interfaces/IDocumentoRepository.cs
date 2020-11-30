using System;
using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDocumentoRepository<T> where T : IDocumento
    {
        T BuscarPorId(int idDocumento);
        T BuscarPorLlave(string codigoConcepto, string serie, string folio);
        T BuscarPorLlave(tLlaveDoc tLlaveDocumento);
        tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto);
        IEnumerable<T> TraerTodo();
        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor);
        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, IEnumerable<string> codigosClienteProveedor);
    }
}