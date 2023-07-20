using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications;

public sealed class ValorClasificacionPorIdSpecification : SingleResultSpecification<admClasificacionesValores>
{
    public ValorClasificacionPorIdSpecification(int idValorClasificacion)
    {
        Query.Where(valor => valor.CIDVALORCLASIFICACION == idValorClasificacion);
    }
}

public sealed class ValorClasificacionPorClasificacionIdYCodigoSpecification : SingleResultSpecification<admClasificacionesValores>
{
    public ValorClasificacionPorClasificacionIdYCodigoSpecification(int idClasificacion, string codigoValorClasificacion)
    {
        Query.Where(valor => valor.CIDCLASIFICACION == idClasificacion && valor.CCODIGOVALORCLASIFICACION == codigoValorClasificacion);
    }
}

public sealed class ValoresClasificacionPorClasificacionIdSpecification : Specification<admClasificacionesValores>
{
    public ValoresClasificacionPorClasificacionIdSpecification(int idClasificacion)
    {
        Query.Where(valor => valor.CIDCLASIFICACION == idClasificacion);
    }
}