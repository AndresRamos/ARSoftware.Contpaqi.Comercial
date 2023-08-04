using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;

/// <summary>
///     Especificación para obtener una clasificación por su id.
/// </summary>
public sealed class ClasificacionPorIdSpecification : SingleResultSpecification<admClasificaciones>
{
    public ClasificacionPorIdSpecification(int idClasificacion)
    {
        Query.Where(clasificacion => clasificacion.CIDCLASIFICACION == idClasificacion);
    }
}
