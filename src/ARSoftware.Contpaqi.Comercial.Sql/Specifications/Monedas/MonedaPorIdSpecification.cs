using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Monedas;

/// <summary>
///     Especificación para obtener una moneda por su id.
/// </summary>
public sealed class MonedaPorIdSpecification : SingleResultSpecification<admMonedas>
{
    public MonedaPorIdSpecification(int idMoneda)
    {
        Query.Where(moneda => moneda.CIDMONEDA == idMoneda);
    }
}
