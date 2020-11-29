using System;
using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDocumentoRepository<T> where T : IDocumento
    {
        T FindById(int idDocumento);
        T FindByLlave(string codigoConcepto, string serie, string folio);
        T FindByLlave(tLlaveDoc tLlaveDocumento);
        tLlaveDoc FindNextSerieAndFolio(string codigoConcepto);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByRangoFechaAndCodigoConceptoAndCodigoClienteProveedor(DateTime fechaInicio, DateTime fechaFin, string codigoConcepto, string codigoClienteProveedor);
    }
}