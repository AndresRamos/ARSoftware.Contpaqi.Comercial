using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;

/// <summary>
///     Especificación para obtener clasificaciones por tipo.
/// </summary>
public sealed class ClasificacionesPorTipoSpecification : Specification<admClasificaciones>
{
    public ClasificacionesPorTipoSpecification(TipoClasificacion tipo)
    {
        int idClasificacionInicio = ((int)tipo - 1) * 6 + 1;
        int idClasificacionFin = idClasificacionInicio + 5;

        Query.Where(clasificacion =>
            clasificacion.CIDCLASIFICACION >= idClasificacionInicio && clasificacion.CIDCLASIFICACION <= idClasificacionFin);
    }
}
