using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories
{
    public interface IDocumentoRepository<T> where T : class, new()
    {
        T BuscarPorId(int idDocumento);
        T BuscarPorLlave(string codigoConcepto, string serie, string folio);
        T BuscarPorLlave(LlaveDocumento tLlaveDocumento);
        LlaveDocumento BuscarSiguienteSerieYFolio(string codigoConcepto);

        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
            string codigoConcepto, string codigoClienteProveedor);

        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin,
            string codigoConcepto, IEnumerable<string> codigosClienteProveedor);

        IEnumerable<T> TraerTodo();
    }
}