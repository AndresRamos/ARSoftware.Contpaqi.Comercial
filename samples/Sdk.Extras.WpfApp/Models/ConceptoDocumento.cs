using System;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace Sdk.Extras.WpfApp.Models;

public class ConceptoDocumento : admConceptos
{
    public bool Contains(string filtro)
    {
        return string.IsNullOrWhiteSpace(filtro) ||
               CIDCONCEPTODOCUMENTO.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CCODIGOCONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
               CNOMBRECONCEPTO.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    public override string ToString()
    {
        return $"{CCODIGOCONCEPTO} - {CNOMBRECONCEPTO}";
    }
}
