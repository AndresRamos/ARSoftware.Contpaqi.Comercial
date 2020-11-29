using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IConceptoDocumentoRepository<T> where T : IConceptoDocumento
    {
        T FindById(int idConcepto);
        T FindByCodigo(string codigoConcepto);
        IEnumerable<T> GetAll();
    }
}