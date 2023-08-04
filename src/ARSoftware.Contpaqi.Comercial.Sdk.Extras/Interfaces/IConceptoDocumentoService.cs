using System.Collections.Generic;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IConceptoDocumentoService
{
    void Actualizar(int idConcepto, Dictionary<string, string> datosConcepto);
    void Actualizar(string codigoConcepto, Dictionary<string, string> datosConcepto);
}
