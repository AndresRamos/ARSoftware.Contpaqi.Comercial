using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresClasificacion;

/// <summary>
///     Especificación para obtener un valor de clasificación por su id de clasificación y código.
/// </summary>
public sealed class ValorClasificacionPorClasificacionIdYCodigoSpecification : SingleResultSpecification<admClasificacionesValores>
{
    public ValorClasificacionPorClasificacionIdYCodigoSpecification(int idClasificacion, string codigoValorClasificacion)
    {
        Query.Where(valor => valor.CIDCLASIFICACION == idClasificacion && valor.CCODIGOVALORCLASIFICACION == codigoValorClasificacion);
    }
}
