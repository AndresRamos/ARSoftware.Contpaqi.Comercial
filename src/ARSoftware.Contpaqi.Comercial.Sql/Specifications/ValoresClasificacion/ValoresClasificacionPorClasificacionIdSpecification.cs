using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.ValoresClasificacion;

/// <summary>
///     Especificación para obtener los valores de clasificación por su id de clasificación.
/// </summary>
public sealed class ValoresClasificacionPorClasificacionIdSpecification : Specification<admClasificacionesValores>
{
    public ValoresClasificacionPorClasificacionIdSpecification(int idClasificacion)
    {
        Query.Where(valor => valor.CIDCLASIFICACION == idClasificacion);
    }
}
