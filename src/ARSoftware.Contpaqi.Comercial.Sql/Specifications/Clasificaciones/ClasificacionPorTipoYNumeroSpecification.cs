using Ardalis.Specification;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sql.Specifications.Clasificaciones;

/// <summary>
///     Especificación para obtener una clasificación por su tipo y número.
/// </summary>
public sealed class ClasificacionPorTipoYNumeroSpecification : SingleResultSpecification<admClasificaciones>
{
    public ClasificacionPorTipoYNumeroSpecification(TipoClasificacion tipo, NumeroClasificacion numero)
    {
        // Ids de clasificaciones:
        // Agentes: 1-6
        // Clientes: 7-12
        // Proveedores: 13-18
        // Almacenes: 19-24
        // Productos: 25-30

        int idClasificacionInicio = ((int)tipo - 1) * 6 + 1;
        int idNumeroClasificacion = idClasificacionInicio + (int)numero - 1;

        // Si el tipo es TipoClasificacion.Agente y el numero es NumeroClasificacion.Dos
        // idClasificacionInicio = (1 - 1) * 6 + 1 = 1
        // idNumeroClasificacion = 1 + 2 - 1 = 2

        // Si el tipo es TipoClasificacion.Producto y el numero es NumeroClasificacion.Seis
        // idClasificacionInicio = (5 - 1) * 6 + 1 = 25
        // idNumeroClasificacion = 25 + 6 - 1 = 30

        Query.Where(clasificacion => clasificacion.CIDCLASIFICACION == idNumeroClasificacion);
    }
}
