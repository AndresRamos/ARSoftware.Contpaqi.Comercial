using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresClasificacion;

/// <summary>
///     Especificación para obtener un valor de clasificación por su id.
/// </summary>
public sealed class ValorClasificacionPorIdSpecification : SingleResultSpecification<admClasificacionesValores>
{
    public ValorClasificacionPorIdSpecification(int idValorClasificacion)
    {
        Query.Where(valor => valor.CIDVALORCLASIFICACION == idValorClasificacion);
    }
}
