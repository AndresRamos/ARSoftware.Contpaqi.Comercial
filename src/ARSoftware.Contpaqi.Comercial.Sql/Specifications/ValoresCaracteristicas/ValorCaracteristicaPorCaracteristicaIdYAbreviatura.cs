using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresCaracteristicas;

/// <summary>
///    Especificación para obtener un valor de característica por su id de característica y abreviatura.
/// </summary>
public sealed class ValorCaracteristicaPorCaracteristicaIdYAbreviatura : SingleResultSpecification<admCaracteristicasValores>
{
    public ValorCaracteristicaPorCaracteristicaIdYAbreviatura(int idCaracteristica, string abreviatura)
    {
        Query.Where(v => v.CIDPADRECARACTERISTICA == idCaracteristica && v.CNEMOCARACTERISTICA == abreviatura);
    }
}
