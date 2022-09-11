using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IDocumentoRepository<T> where T : class, new()
    {
        T BuscarPorId(int idDocumento);
        T BuscarPorLlave(string codigoConcepto, string serie, string folio);
        T BuscarPorLlave(tLlaveDoc tLlaveDocumento);
        tLlaveDoc BuscarSiguienteSerieYFolio(string codigoConcepto);

        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio,
                                                                                DateTime fechaFin,
                                                                                string codigoConcepto,
                                                                                string codigoClienteProveedor);

        IEnumerable<T> TraerPorRangoFechaYCodigoConceptoYCodigoClienteProveedor(DateTime fechaInicio,
                                                                                DateTime fechaFin,
                                                                                string codigoConcepto,
                                                                                IEnumerable<string> codigosClienteProveedor);

        IEnumerable<T> TraerTodo();
    }
}
