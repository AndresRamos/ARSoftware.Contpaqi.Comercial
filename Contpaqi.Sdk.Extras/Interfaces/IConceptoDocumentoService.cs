using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IConceptoDocumentoService
    {
        void Actualizar(int idConcepto, Dictionary<string, string> datosConcepto);
        void Actualizar(string codigoConcepto, Dictionary<string, string> datosConcepto);
    }
}
