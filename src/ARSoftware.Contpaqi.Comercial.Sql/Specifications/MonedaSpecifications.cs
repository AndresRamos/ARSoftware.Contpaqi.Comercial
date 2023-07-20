using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class MonedaPorIdSpecification : SingleResultSpecification<admMonedas>
{
    public MonedaPorIdSpecification(int idMoneda)
    {
        Query.Where(moneda => moneda.CIDMONEDA == idMoneda);
    }
}

public sealed class MonedaPorNombreSpecification : Specification<admMonedas>
{
    public MonedaPorNombreSpecification(string nombreMoneda)
    {
        Query.Where(moneda => moneda.CNOMBREMONEDA == nombreMoneda);
    }
}