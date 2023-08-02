using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Monedas;

/// <summary>
///     Especificación para obtener una moneda por su nombre.
/// </summary>
public sealed class MonedaPorNombreSpecification : SingleResultSpecification<admMonedas>
{
    public MonedaPorNombreSpecification(string nombreMoneda)
    {
        Query.Where(moneda => moneda.CNOMBREMONEDA == nombreMoneda);
    }
}
